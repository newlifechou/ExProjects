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
    }
}
