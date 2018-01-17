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
        static  void Main(string[] args)
        {
            //SimpleThread test = new SimpleThread();
            //test.Six();

            //SyncThread test = new SyncThread();
            //test.Nine();

            //ThreadPoolTest test = new ThreadPoolTest();
            //test.Four();

            //TaskTest test = new TaskTest();
            //test.Two();

            AsyncTest test = new AsyncTest();
            test.Two();



            Console.Read();
        }
    }
}
