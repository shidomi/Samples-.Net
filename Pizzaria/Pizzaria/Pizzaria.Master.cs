using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Messaging;
using System.Configuration;
using System.Threading;
using System.Data;
using Pizzaria.Data.Model;

namespace Pizzaria
{
    public partial class Pizzaria : System.Web.UI.MasterPage
    {
        public static string msgContent { get; set; }
        static Thread t;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                t = new Thread(new ThreadStart(StartThread));
                t.Start();
                Timer1.Enabled = true;
            }
        }

        protected void Timer_Tick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(msgContent))
            {
                Data.Model.Customer cst = new Data.Model.Customer();
                DataTable dt = new DataTable();

                dt = cst.GetCustomerByNumber(msgContent);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                        lbl.Text = "cst=" + dt.Rows[0].ItemArray[0].ToString() + "&" + "nome=" + dt.Rows[0].ItemArray[1].ToString() + "&" +
                                   "tel=" + dt.Rows[0].ItemArray[2].ToString() + "&" + "end=" + dt.Rows[0].ItemArray[3].ToString() + "&" +
                                   "barr=" + dt.Rows[0].ItemArray[4].ToString() + "&" + "num=" + dt.Rows[0].ItemArray[5].ToString() + "&" +
                                   "comp=" + dt.Rows[0].ItemArray[6].ToString() + "&" + "obs=" + dt.Rows[0].ItemArray[7].ToString();
                    else
                        lbl.Text = "new " + msgContent;

                    msgContent = "";
                }
            }
            else
                lbl.Text = "";

        }

        #region Thread da fila

        public void StartThread()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    PrepareQueue();
                }
            }
            catch (Exception)
            { }
        }

        public static void PrepareQueue()
        {
            string msqName = ConfigurationManager.AppSettings["MSQName"].ToString();
            MessageQueue myQueue = new MessageQueue(".\\private$\\" + msqName);
            myQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });

            myQueue.ReceiveCompleted += new ReceiveCompletedEventHandler(MyReceiveCompleted);

            WaitHandle[] waitHandleArray = new WaitHandle[10];
            for (int i = 0; i < 10; i++)
            {
                waitHandleArray[i] = myQueue.BeginReceive().AsyncWaitHandle;
            }

            WaitHandle.WaitAll(waitHandleArray);

            return;
        }

        private static void MyReceiveCompleted(Object source, ReceiveCompletedEventArgs asyncResult)
        {
            try
            {
                MessageQueue mq = (MessageQueue)source;

                System.Messaging.Message m = mq.EndReceive(asyncResult.AsyncResult);
                msgContent = m.Body.ToString();
            }
            catch (MessageQueueException)
            { }

            return;
        }

        #endregion

    }
}