using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            TestReflection test = new TestReflection();
            test.Test();
            Console.WriteLine("执行完毕");
            Console.Read();
        }
    }
}
