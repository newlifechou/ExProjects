using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Examples_CSharp.Src
{
    /// <summary>
    /// 表达式树
    /// </summary>
    class Chapter09
    {
        public void Test1()
        {
            Func<string, int> returnLength;
            returnLength = delegate (string text) { return text.Length; };


        }

        public void Test2()
        {
            Expression firstArg = Expression.Constant(2);
            Expression secondArg = Expression.Constant(3);
            Expression add = Expression.Add(firstArg, secondArg);
            Console.WriteLine(add);

        }


    }
}
