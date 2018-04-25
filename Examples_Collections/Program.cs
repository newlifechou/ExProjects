using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in new DataCollection())
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
