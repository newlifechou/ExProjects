using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace Examples_IO.Src
{
    class TestZip
    {
        /// <summary>
        /// 使用ZipFile静态类
        /// 需要引用FileSystem dll
        /// </summary>
        public void TestZipFile()
        {
            string startPath = Path.Combine(Directory.GetCurrentDirectory(), "Zip");
            string zipPath = Path.Combine(Directory.GetCurrentDirectory(), "zip.zip");
            string extractPath = Path.Combine(Directory.GetCurrentDirectory(), "Extract");
            if (File.Exists(zipPath))
            {
                File.Delete(zipPath);
            }

            ZipFile.CreateFromDirectory(startPath, zipPath);
            Console.WriteLine("压缩成功");

            Directory.Delete(extractPath, true);
            Directory.CreateDirectory(extractPath);

            ZipFile.ExtractToDirectory(zipPath, extractPath);
            Console.WriteLine("解压缩成功");

            // System.Diagnostics.Process.Start(extractPath);

            string newfile = Path.Combine(Directory.GetCurrentDirectory(), "Examples_IO.exe.config");

            ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update);
            archive.CreateEntryFromFile(newfile, "Examples_IO.exe.config");
            //archive.ExtractToDirectory(extractPath);
            Console.WriteLine("添加文件到刚才这个压缩包");
            foreach (var file in archive.Entries)
            {
                Console.WriteLine(file.Name);
            }

            ZipArchiveEntry entry = archive.GetEntry("Examples_IO.exe.config");
            StreamReader sr = new StreamReader(entry.Open());
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
            entry.Delete();
            Console.WriteLine("删除这个文件");
            foreach (var file in archive.Entries)
            {
                Console.WriteLine(file.Name);
            }
            archive.Dispose();
        }



    }
}
