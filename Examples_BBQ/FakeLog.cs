using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_BBQ
{
    public class FakeLog : ILog
    {
        public string Log { get; set; }

        public string Read()
        {
            return "fuck";
        }

        public void Write(string msg)
        {
            Log = msg;
        }
    }
}
