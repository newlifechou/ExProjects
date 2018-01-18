using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examples_IO.Src
{
    /// <summary>
    /// 该类测试了binary reader and writer
    /// </summary>
    class BinaryReaderWriter
    {
        private string filePath;
        public BinaryReaderWriter()
        {
            filePath = Path.Combine(Environment.CurrentDirectory, "binary.dat");
        }

        public void TestRW()
        {
            WriteIt();

            ReadIt();
        }

        public void TestSeek()
        {
            WriteBySeek();
        }

        private void WriteIt()
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fs);
            writer.Write(true);
            writer.Write(1.25f);
            writer.Write(10);
            writer.Write("hello world");
            writer.Close();
        }
        private void ReadIt()
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);
            Console.WriteLine(reader.ReadBoolean());
            Console.WriteLine(reader.ReadSingle());
            Console.WriteLine(reader.ReadInt32());
            Console.WriteLine(reader.ReadString());

            reader.Close();

        }

        private void WriteBySeek()
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            UTF8Encoding utf8 = new UTF8Encoding();
            BinaryWriter w = new BinaryWriter(fs, utf8);
            int pos;
            for (pos = 0; pos < 128; pos++)
            {
                w.Write((byte)(255 - pos));
            }
            w.Close();

            BinaryReader r = new BinaryReader(File.OpenRead(filePath), utf8);
            r.BaseStream.Seek(20, SeekOrigin.Begin);
            Console.WriteLine(r.ReadByte());
            //byte[] raw = new byte[128];
            //fs.Read(raw, 0, 128);
            //foreach (var item in raw)
            //{
            //    Console.WriteLine(item);
            //}


        }




    }
}
