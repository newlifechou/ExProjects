using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_QuartzNet
{
    class Program
    {
        static void Main(string[] args)
        {
            QuartzOperation.Start();
            Console.WriteLine("Plan is running");
            Console.WriteLine("press any key to close this application");
            Console.Read();
        }
    }
}
