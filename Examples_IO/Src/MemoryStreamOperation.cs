using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examples_IO.Src
{
    /// <summary>
    /// 演示内存流
    /// </summary>
    static class MemoryStreamOperation
    {
        public static void ReadWrite()
        {
            string s1 = "the brown fox jumps over the lazy dog";
            string s2 = "the second product";
            string s3 = "crazy 8";

            byte[] bytes1 = Encoding.Default.GetBytes(s1);
            byte[] bytes2 = Encoding.Default.GetBytes(s2);
            byte[] bytes3 = Encoding.Default.GetBytes(s3);

            using (var ms = new MemoryStream())
            {
                ms.Write(bytes1, 0, bytes1.Length);
                ms.Write(bytes2, 0, bytes2.Length);
                foreach (var item in bytes3)
                {
                    ms.WriteByte(item);
                }
                Console.WriteLine("Write Done");

                //必须控制游标到开始的地方
                ms.Seek(0, SeekOrigin.Begin);

                byte[] read_bytes = new byte[bytes1.Length+bytes2.Length+bytes3.Length];
                ms.Read(read_bytes, 0, bytes1.Length + bytes2.Length + bytes3.Length);

                string ss = Encoding.Default.GetString(read_bytes);
                Console.WriteLine(ss);

                Console.WriteLine("Read  Done");
            }

        }


    }
}
