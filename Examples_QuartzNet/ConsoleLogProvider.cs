using Quartz.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_QuartzNet
{
    public class ConsoleLogProvider : ILogProvider
    {
        public Logger GetLogger(string name)
        {
            return (l, f, e, p) =>
            {
                if (l >= LogLevel.Info && f != null)
                {
                    string s = $"[{DateTime.Now.ToLongTimeString()}] [{l}] {f()} {p}";
                    Console.WriteLine(s);
                }
                return true;
            };
        }

        public IDisposable OpenMappedContext(string key, string value)
        {
            throw new NotImplementedException();
        }

        public IDisposable OpenNestedContext(string message)
        {
            throw new NotImplementedException();
        }
    }
}
