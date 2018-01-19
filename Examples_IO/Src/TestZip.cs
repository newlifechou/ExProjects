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
        public void Test1()
        {
            string startPath = Path.Combine(Directory.GetCurrentDirectory(), "Zip");
            string zipPath = Path.Combine(Directory.GetCurrentDirectory(), "zip.zip");
            string extractPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            ZipFile.CreateFromDirectory(startPath, zipPath);
            Console.WriteLine("压缩成功");




        }



    }
}
