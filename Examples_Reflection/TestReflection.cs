using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace UseReflection
{
    public class TestReflection
    {
        public void Test()
        {
            var a = Assembly.LoadFrom("UseReflectionDll.dll");

        }



    }
}
