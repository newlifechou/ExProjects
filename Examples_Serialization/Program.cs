using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //new XmlOperation().SingleXml();

            //JsonOperation.JSS();

            //JsonOperation.DCJS();

            JsonOperation.NewtonJsonLinq();

            Console.Read();
        }
    }
}
