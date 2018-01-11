using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiThreading.Src;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleThread test = new SimpleThread();
            test.One();




            Console.Read();
        }
    }
}
