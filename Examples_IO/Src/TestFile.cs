using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examples_IO.Src
{
    class TestFile
    {
        public void One()
        {
            if (File.Exists("binary.dat"))
            {
                Console.WriteLine("Exist");
            }
            else
            {
                Console.WriteLine("Not Exisit");
            }

        }

        public void Two()
        {
            File.AppendAllText("fileappend.txt", "hello world");
        }

    }
}
