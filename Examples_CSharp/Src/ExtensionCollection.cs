using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_CSharp.Src
{
    static class ExtensionCollection
    {
        public static int MyLength(this string str)
        {
            return str.Length;
        }
    }
}
