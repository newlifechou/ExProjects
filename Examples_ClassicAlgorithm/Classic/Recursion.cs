using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.Classic
{
    /// <summary>
    /// 这个类中包含各种递归算法
    /// 
    /// </summary>
    public class Recursion
    {
        /// <summary>
        /// Fib计算
        /// 1,1,2,3,5,8,13,21……
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fib(int n)
        {
            if (n == 1 || n == 2) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
