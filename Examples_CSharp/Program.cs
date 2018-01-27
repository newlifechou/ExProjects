using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples_CSharp.Src;

namespace Examples_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Chapter06 ct = new Chapter06();
            foreach (var item in ct)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
