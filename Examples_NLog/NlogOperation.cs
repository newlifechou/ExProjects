using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

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
        public static void ConfigMannully()
        {
            var config = new NLog.Config.LoggingConfiguration();

            var logfile = new NLog.Targets.FileTarget() { FileName = "log.txt", Name = "logfile" };
            config.LoggingRules.Add(new NLog.Config.LoggingRule("*", LogLevel.Error, logfile));

            NLog.LogManager.Configuration = config;
        }

        public static void Log(string msg)
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
