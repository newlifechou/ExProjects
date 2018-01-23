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


    }
}
