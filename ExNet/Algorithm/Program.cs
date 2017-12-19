using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            int g = 1;
            for (int i = 0; i <=15; i++)
            {
                Console.WriteLine(i+"="+f+" "+g);
                f = f + g;
                g = f - g;
            }


            Console.Read();
        }
    }
}
