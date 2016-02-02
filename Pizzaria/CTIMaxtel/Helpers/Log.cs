using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTIMaxtel.Helpers
{
    class Log
    {
        public static void Trace(string msg) 
        {
            if (!EventLog.SourceExists("CTIMaxtel"))
            {
                EventLog.CreateEventSource("CTIMaxtel", "CTIMaxtel");
                return;
            }

            EventLog myLog = new EventLog();
            myLog.Source = "CTIMaxtel";

            myLog.WriteEntry(msg);
        }
    }
}
