using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examples_IO
{
    class FileWatch
    {
        public void Watch()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            watcher.Path = Path.Combine(desktop, "180423");
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Deleted += Watcher_Deleted;
            watcher.Created += Watcher_Created;
            watcher.Renamed += Watcher_Renamed;
            watcher.Changed += Watcher_Changed;
            watcher.EnableRaisingEvents = true;

            Console.WriteLine("watching is starting");
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File Changed");

        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("File Renamed");

        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File Created");

        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File Deleted");
        }
    }
}
