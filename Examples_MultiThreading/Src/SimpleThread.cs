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
        #region TestMethod
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

        public void Three()
        {
            var t1 = new Thread(Delay);
            var t2 = new Thread(Delay);
            t1.IsBackground = true;
            t1.Start(5000);
            t2.Start(6000);
        }

        public void Four()
        {
            int i = 10;
            var t1 = new Thread(() => Console.WriteLine(i));
            //i = 20;
            var t2 = new Thread(() => Console.WriteLine(i));
            t1.Start();
            t2.Start();

        }


        public void Five()
        {
            var c = new Counter();
            var t1 = new Thread(() => TestCounter(c));
            var t2 = new Thread(() => TestCounter(c));
            var t3 = new Thread(() => TestCounter(c));
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine(c.Count);



        }

        public void Six()
        {
            try
            {
                var t = new Thread(Bad);
                t.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TestCounter(Counter c)
        {
            for (int i = 0; i < 10000; i++)
            {
                c.Increase();
                c.Decrease();
            }
        }


        #endregion

        private void Delay(object s)
        {
            int t = (int)s;
            Thread.Sleep(t);
            Console.WriteLine("Job Done" + t);
        }

       private void Bad()
        {
            try
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                throw new Exception("Boom");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
