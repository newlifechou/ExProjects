using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_BBQ
{
    public class Foo
    {
        private ILog _log;
        public Foo(ILog log)
        {
            _log = log;
        }
        public void Do()
        {
            _log.Write("Finish A");
        }
    }
}
