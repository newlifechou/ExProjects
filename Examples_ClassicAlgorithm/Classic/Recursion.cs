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
        /// <summary>
        /// 阶乘
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
            {
                return n * Factorial(n - 1);
            }
        }
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int SumAll(int n)
        {
            if (n == 0)
                return 0;
            else
                return n + SumAll(n - 1);
        }

        /// <summary>
        /// 汉诺塔问题
        ///A柱经过辅助B柱移动到C柱，小盘子必须在大盘子之上。
        ///不好理解
        /// </summary>
        public void HanoiTower()
        {

        }

    }
}
