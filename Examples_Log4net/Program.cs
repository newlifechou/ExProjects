using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Log4net
{
    /// <summary>
    /// 这个项目是为了演示log4net的使用
    /// http://logging.apache.org/log4net/index.html
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Log4netOperation();
            logger.LogError();
            logger.LogInfo();




            Console.WriteLine("Done");

            Console.Read();
        }
    }
}
