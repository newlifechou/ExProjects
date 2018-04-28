using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_NLog
{
    class Program
    {
        static void Main(string[] args)
        {
            //先然Nlog比log4net更好用一些
            NlogOperation.LogByConfigMannully("something is wrong");

            Console.Read();
        }
    }
}
