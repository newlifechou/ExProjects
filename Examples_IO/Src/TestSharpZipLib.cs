using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Checksums;

namespace Examples_IO.Src
{
    public class TestSharpZipLib
    {
        private string source = Path.Combine(Directory.GetCurrentDirectory(), "Zip");

        public void TestUnZip()
        {



        }

        public void TestZip()
        {
            DirectoryInfo dir = new DirectoryInfo(source);
            if (File.Exists("myzip.zip")) File.Delete("myzip.zip");
            ZipFile target = ZipFile.Create("myzip.zip");
            target.BeginUpdate();
            //target.AddDirectory(source);
            foreach (var file in dir.GetFiles())
            {
                target.Add(file.FullName, file.Name);
            }

            target.SetComment("这是我的压缩包");
            target.CommitUpdate();
            Console.WriteLine("压缩成功");




        }

        public void ReadZip()
        {
            using (var zip = new ZipFile("myzip.zip"))
            {
                foreach (var item in zip)
                {
                    Console.WriteLine((item as ZipEntry).Name);
                }
            }
            Console.WriteLine("读取压缩包完毕");
        }


        public void FastZip()
        {
            var fast = new FastZip();
            fast.CreateZip("fastzip.zip", "zip", true, "");
            Console.WriteLine("创建压缩包完毕");
            fast.ExtractZip("fastzip.zip", "zip2", "");
            Console.WriteLine("解压缩包完毕");

        }

        public void TestZipOutputStream()
        {
            ZipOutputStream zs = new ZipOutputStream(File.Create("123.zip"));
            zs.SetLevel(6);
            FileStream fs = File.OpenRead("Examples_IO.exe.config");
            byte[] buffer = new byte[4 * 1024];
            ZipEntry entry = new ZipEntry("Examples.config");
            entry.DateTime = DateTime.Now;
            zs.PutNextEntry(entry);
            int sourcebytes = 0;
            do
            {
                sourcebytes = fs.Read(buffer, 0, buffer.Length);
                zs.Write(buffer, 0, sourcebytes);
            } while (sourcebytes > 0);
            zs.CloseEntry();
            Console.WriteLine("写入完毕");

        }

    }
}
