using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_BBQ
{
    public interface ILog
    {
        void Write(string msg);
        string Read();
    }
}
