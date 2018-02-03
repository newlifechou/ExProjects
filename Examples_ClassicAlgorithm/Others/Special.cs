using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.Others
{
    class Special
    {
        /// <summary>
        /// 冰雹算法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int HailStone(int n)
        {
            Console.Write($"{n} ");
            if (n <= 1) return 1;
            if (n % 2 == 0)
                return HailStone(n / 2);
            else
                return HailStone(3 * n + 1);
        }
    }
}
