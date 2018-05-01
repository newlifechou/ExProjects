using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_BBQ
{
    public class Log:ILog
    {
        public string Read()
        {
            return "fuck";
        }

        public void Write(string msg)
        {
            Console.WriteLine($"写入控制台{msg}");
        }
    }
}
