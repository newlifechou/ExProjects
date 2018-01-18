using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples_IO.Src;


namespace Examples_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("开始程序");
            BinaryReaderWriter test = new BinaryReaderWriter();
            test.TestRW();
            


            Console.Read();
        }
    }
}
