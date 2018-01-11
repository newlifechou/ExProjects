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
            t5.Start();
            Thread.Sleep(5000);
            t5.Abort();


            //PrintLetters();
        }


        private void PrintNumber1()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(200);
                Console.Write(" 1 ");
            }

        }
        private void PrintNumber2()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(200);
                Console.Write(" 2 ");
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
                Thread.Sleep(5000);
                Console.Write(letter.ToString());
        }


    }
}
