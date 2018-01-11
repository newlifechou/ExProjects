using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //Thread t1 = new Thread(PrintNumber1);
            //t1.Start();
            //Thread t2 = new Thread(PrintNumber2);
            //t2.Start();
            //var t3 = new Thread(PrintLove);
            //t3.Start();

            //Thread t4 = new Thread(new ParameterizedThreadStart(Print));
            //t4.Start("XXXXXXX");
            //t4.Join();

            Thread t5 = new Thread(PrintNumber1);
            Console.WriteLine(t5.ThreadState.ToString());
            t5.Start();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(t5.ThreadState.ToString());
            }

            Thread.Sleep(5000);
            t5.Abort();
            Console.WriteLine(t5.ThreadState.ToString());




            //PrintLetters();
        }

        public void Two()
        {
            var t1 = new Thread(Print);
            var t2 = new Thread(Print);
            t1.Name = "Thread1";
            t2.Name = "Thread2";
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(1);

            t1.Start("A");
            t2.Start("B");


            for (int i = 0; i < 1000000; i++)
            {
                Console.Write("C");
            }

        }

        private void PrintNumber1()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                Console.Write("A");
            }

        }
        private void PrintNumber2()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                Console.Write("B");
            }

        }

        private void PrintLetters()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(200);
                Console.Write(" A ");
            }
        }


        private static void PrintLove()
        {
            while (true)
            {
                Thread.Sleep(200);
                Console.Write(" LOVE ");
            }
        }

        private void Print(object letter)
        {
            while (true)
            {
                Console.Write(letter.ToString());
            }
        }


    }
}
