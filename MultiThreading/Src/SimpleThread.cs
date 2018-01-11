using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Src
{
    internal class SimpleThread
    {
        public void One()
        {
            Thread t = new Thread(PrintNumbers);
            t.Start();
            PrintLetters();
        }


        private void PrintNumbers()
        {
            Console.WriteLine("Starting");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(200);
                Console.Write(i);
            }

        }

        private void PrintLetters()
        {
            Console.WriteLine("Starting");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(200);
                Console.Write("A");
            }
        }

    }
}
