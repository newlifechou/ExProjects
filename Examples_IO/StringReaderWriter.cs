using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_IO
{
    static class StringReaderWriter
    {
        public static void Do()
        {
            StringReader sr = new StringReader("hello world");
            Console.WriteLine((char)sr.Read());
        }
    }
}
