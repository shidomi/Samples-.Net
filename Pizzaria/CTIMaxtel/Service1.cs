using CTIMaxtel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Messaging;
using System.Configuration;

namespace CTIMaxtel
{
    public partial class CTIMaxtel : ServiceBase
    {
        static bool _continue;
        static SerialPort _serialPort;

        static string nmbr;

        public CTIMaxtel()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Thread t = new Thread(new ThreadStart(this.OpenSerialPort));
            t.Start();
        }

        protected override void OnStop()
        {
            _serialPort.Close();
        }

        public void OpenSerialPort()
        {
            _serialPort = new SerialPort();
            
            _serialPort.PortName = ConfigurationManager.AppSettings["PortName"].ToString();
            _serialPort.BaudRate = Int32.Parse(ConfigurationManager.AppSettings["BaudRate"].ToString());
            _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), ConfigurationManager.AppSettings["Parity"].ToString(), true);
            _serialPort.DataBits = Int32.Parse(ConfigurationManager.AppSettings["DataBits"].ToString());
            _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), ConfigurationManager.AppSettings["StopBits"].ToString(), true);
            _serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), ConfigurationManager.AppSettings["Handshake"].ToString(), true);
            _serialPort.ReadTimeout = Int32.Parse(ConfigurationManager.AppSettings["ReadTimeout"].ToString());
            _serialPort.WriteTimeout = Int32.Parse(ConfigurationManager.AppSettings["WriteTimeout"].ToString());

            try
            {
                _serialPort.Open();
                _continue = true;
                Log.Trace("CTIMaxtel: Porta serial aberta com sucesso !");
            }
            catch (Exception)
            {
                Log.Trace("CTIMaxtel: Exceção ao abrir porta serial !");
            }

            #region Comandos iniciais

            byte[] callId = {0x41,
                             0x54,
                             0x2B,
                             0x56,
                             0x43,
                             0x49,
                             0x44,
                             0x3D,
                             0x31,
                             0x0D,
                             0x41,
                             0x54,
                             0x2B,
                             0x56,
                             0x43,
                             0x49,
                             0x44,
                             0x3D,
                             0x31,
                             0x0D,
                             0x0D,
                             0x0A,
                             0x4F,
                             0x4B,
                             0x0D,
                             0x0A};
            #endregion

            try
            {
                _serialPort.Write(callId, 0, 26);
                Log.Trace("CTIMaxtel: Comando 'AT+VCID=1' enviado com sucesso !");
            }
            catch (Exception)
            {
                Log.Trace("CTIMaxtel: Exceção ao enviar o comando 'AT+VCID=1' !");
            }            

            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    if (message.Contains("NMBR"))
                    {
                        nmbr = String.Join("", System.Text.RegularExpressions.Regex.Split(message, @"[^\d]"));
                        SendCaller(nmbr);
                    }
                }
                catch (System.TimeoutException) { }
            }
        }

        public void SendCaller(string nmbr)
        {
            string msqName = ConfigurationManager.AppSettings["MSQName"].ToString();

            if (!String.IsNullOrEmpty(msqName))
            {
                try
                {
                    MessageQueue queue = new MessageQueue(".\\private$\\" + msqName);
                    queue.Send(nmbr);
                }
                catch (Exception)
                {
                    Log.Trace("CTIMaxtel: Exceção ao adicionar ligação na fila !");
                }
            }
        }
    }
}
