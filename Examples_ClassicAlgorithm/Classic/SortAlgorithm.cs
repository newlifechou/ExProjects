using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.Classic
{
    /// <summary>
    /// 排序算法集合
    ///所有的排序都是从小到大
    /// </summary>
    public class SortAlgorithm
    {

        #region 公共方法
        /// <summary>
        /// 交换
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        #endregion

        /// <summary>
        /// 冒泡法排序-最普通的
        /// 主要思想：对比-交换
        /// </summary>
        /// <param name="unsorted"></param>
        public void BubbleSortNormal(int[] unsorted)
        {
            int len = unsorted.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if (unsorted[j] > unsorted[j + 1])
                    {
                        Swap(ref unsorted[j], ref unsorted[j + 1]);
                    }
                }
            }
        }
        /// <summary>
        /// 改进型
        /// 通过判断最后有序的位置来减少总的循环次数
        /// </summary>
        /// <param name="unsorted"></param>
        public void BubbleSortBetter(int[] unsorted)
        {
            int len = unsorted.Length;
            int flag = len;

            while (flag > 0)
            {
                int k = flag;
                flag = 0;
                for (int j = 0; j < k - 1; j++)
                {
                    if (unsorted[j] > unsorted[j + 1])
                    {
                        Swap(ref unsorted[j], ref unsorted[j + 1]);
                        flag = j + 1;
                    }
                }
            }


        }

        /// <summary>
        /// 快速排序
        /// 插入到有序区，搜索，后移
        /// </summary>
        /// <param name="data"></param>
        public void InsertSort(int[] data)
        {
            int len = data.Length;
            int i, j;
            for (i = 1; i < len; i++)
            {
                if (data[i] < data[i - 1])
                {
                    int temp = data[i];
                    for (j = i - 1; j >= 0 && data[j] > temp; j--)
                    {
                        data[j + 1] = data[j];
                    }
                    //因为执行了j--
                    data[j + 1] = temp;
                }
            }
        }

        /// <summary>
        /// 快速排序优化
        /// </summary>
        /// <param name="data"></param>
        public void InsertSortBetter(int[] data)
        {
            int len = data.Length;
            int i, j;
            for (i = 1; i < len; i++)
            {
                for (j = i - 1; j >= 0 && data[j] > data[j + 1]; j--)
                {
                    Swap(ref data[j], ref data[j + 1]);
                }
            }
        }




        /// <summary>
        /// 快速排序
        /// </summary>
        /// 1.从数组中选择一个数作为基数（第一个）
        /// 2.分区，将比它大的分左边，比它小的分右边
        /// 3.对左右分区重复第2步，直到分区只有一个数
        public void QuickSort(int[] unsorted)
        {

        }

        private void Divide(int[] unsorted, int low, int high)
        {

        }






    }
}
