using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm
{
    public static class AlgorithmHelper
    {
        private static Random rand;
        static AlgorithmHelper()
        {
            rand = new Random();
        }
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

        /// <summary>
        /// 生成一个需要个数的随机数组（允许重复）
        /// </summary>
        /// <param name="count"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int[] CreateRandomArray(int count, int maxValue = 100)
        {
            int[] data = new int[count];
            for (int i = 0; i < count; i++)
            {
                data[i] = rand.Next(1, maxValue);
            }
            return data;
        }

    }
}
