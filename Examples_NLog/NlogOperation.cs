using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace Examples_NLog
{
    /// <summary>
    /// http://nlog-project.org/
    /// 比log4net更轻便
    /// NLog日志输出目标
    /// 文件 比如TXT、Excel
    /// 文本控制台
    /// Email
    /// 数据库
    /// 网络中的其它计算机（通过TCP或UDP）
    /// 基于MSMQ的消息队列
    /// Windows系统日志
    /// 可以使用config文件配置，配置文件会按照一定顺序去搜索
    /// 配置文件可以集合在默认的配置文件中，也可以独立
    /// 注意，config文件要设置成Content并且复制到目标文件夹才行
    /// 也可以使用Configuration API代码的方式配置
    /// </summary>
    static class NlogOperation
    {
        public static void LogByConfigMannully(string msg)
        {
            //create a config
            var config = new LoggingConfiguration();
            //create console target
            var consoleTarget = new ColoredConsoleTarget();
            config.AddTarget("console", consoleTarget);

            var fileTarget = new FileTarget("mylog.txt");
            fileTarget.FileName = "file.txt";
            config.AddTarget("logfile", fileTarget);

            //define rules
            var rule1 = new LoggingRule("*", LogLevel.Debug, consoleTarget);
            config.LoggingRules.Add(rule1);

            var rule2 = new LoggingRule("*", LogLevel.Debug, fileTarget);
            config.LoggingRules.Add(rule2);


            LogManager.Configuration = config;

            var logger = LogManager.GetLogger("NlogOperation");
            for (int i = 0; i < 100; i++)
            {
                logger.Debug(msg);
            }
        }

        public static void LogByConfig(string msg)
        {
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Error(msg);
            logger.Info(msg);
            logger.Trace("trace information");
            logger.Warn("hello world");
            logger.Debug("hello debug");
            logger.Fatal("hello fatal");
            Console.WriteLine("Done");

        }
    }
}
