using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Examples_Log4net
{
    class Log4netOperation
    {
        public Log4netOperation()
        {
            //read config
            log4net.Config.XmlConfigurator.Configure();
        }

        public void LogError()
        {
            ILog log = log4net.LogManager.GetLogger("logerror");
            log.Error($"something wrong");
        }

        public void LogInfo()
        {
            ILog log = log4net.LogManager.GetLogger("loginfo");
            log.Error($"something happend");
        }
    }
}
