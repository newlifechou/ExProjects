using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterViewStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                InterviewOperation.RandomValidationCode(5);
                Thread.Sleep(100);
            }
            Console.Read();
        }
    }
}
