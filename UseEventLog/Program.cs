using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UseEventLog
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLogOperate test = new EventLogOperate();
            test.WriteLog("hello world");

            Console.WriteLine("执行完毕");
            Console.Read();
        }
    }
}
