using Examples_ClassicAlgorithm.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Special s = new Special();
            int data = 1000;
            s.HailStone(data);
            Console.WriteLine("算法结束");

            Console.Read();
        }
    }
}
