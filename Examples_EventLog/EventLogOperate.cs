using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UseEventLog
{
    public class EventLogOperate
    {
        public void WriteLog(string logMessage)
        {
            EventLog log = new EventLog
            {
                Log = "System"
            };
            //log.MachineName = "Printer-PC";
            //log.WriteEntry("fuck me", EventLogEntryType.Error);
            //log.WriteEntry("get rid of it", EventLogEntryType.Information);
            //log.WriteEntry(logMessage);
            foreach (EventLogEntry item in log.Entries)
            {
                Console.WriteLine(item.Message);
            }
            log.Close();
        }
    }
}
