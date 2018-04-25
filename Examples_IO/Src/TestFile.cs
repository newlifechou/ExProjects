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

        public void Three()
        {
            //不支持
            //File.Encrypt("fileappend.txt");
            Console.WriteLine("加密文件完成");
        }

        public void Read()
        {
            byte[] data = File.ReadAllBytes("data.dat");
            string content = File.ReadAllText("data.txt");
            string[] lines = File.ReadAllLines("log.txt");

            StreamReader sr = File.OpenText("data.txt");
            FileStream fs = File.Open("fuck.txt",FileMode.Open);

        }

    }
}
