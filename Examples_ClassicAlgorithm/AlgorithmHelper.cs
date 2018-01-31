using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm
{
    public static class AlgorithmHelper
    {
        /// <summary>
        /// 判断一个数组是否有序
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool IsSorted(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[i] > data[i + 1]) return false;
            }
            return true;
        }

    }
}
