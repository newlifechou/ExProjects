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
            //TestBinaryReaderWriter test = new TestBinaryReaderWriter();
            ////test.TestRW();
            //test.TestSeek();

            //TestFile test = new TestFile();
            //test.Three();

            //TestZip test = new TestZip();
            //test.TestGzip();

            TestSharpZipLib test = new TestSharpZipLib();
            test.TestZipOutputStream();



            Console.Read();
        }
    }
}
