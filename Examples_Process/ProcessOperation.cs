using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Examples_Process
{
    /// <summary>
    ///Process类的使用 
    /// </summary>
    static class ProcessOperation
    {
        public static void GetAllProcess()
        {
            var process_list = Process.GetProcesses();
            foreach (var p in process_list)
            {
                Console.WriteLine($"{p.ProcessName} {p.Id}");
            }
        }
    }
}
