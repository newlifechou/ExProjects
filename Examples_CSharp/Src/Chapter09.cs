using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections;

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
            Func<int> compiled = Expression.Lambda<Func<int>>(add).Compile();

            Console.WriteLine(compiled());

            Expression<Func<int>> return5 = () => 5;
            Func<int> compiled2 = return5.Compile();

            "hello world".MyLength();

        }

        public void Test3()
        {
            var list = Enumerable.Range(0, 100);
            var result = list.Where(i => i % 2 == 0).Select(i => new { Number = i });

            var query = from int i in list
                        select i;

            ArrayList list2 = new ArrayList() { "hello", "world" };
            IEnumerable<string> result2 = list2.Cast<String>();
            IEnumerable<string> result3 = list2.OfType<string>();

            var final2 = result3.Select(str => str.Substring(0, 2));




        }





    }
}
