using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Timers
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerOperation.SystemTimers() ;

            Console.WriteLine("main thread is running");
            Console.Read();
        }
    }
}
