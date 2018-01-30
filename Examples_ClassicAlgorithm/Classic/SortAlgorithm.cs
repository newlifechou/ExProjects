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
            if (a == b) return;
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
        /// 插入排序
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
        /// 插入排序优化
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
        /// 希尔排序
        /// 不断分组成更小的序列，直到这些序列的长度等于1
        /// </summary>
        /// <param name="data"></param>
        public void ShellSort(int[] data)
        {
            int n = data.Length;
            int i, j, gap;
            for (gap = n; gap > 0; gap /= 2)
            {
                for (i = gap; i < n; i++)
                {
                    for (j = i - gap; j >= 0 && data[j] > data[j + gap]; j -= gap)
                    {
                        Swap(ref data[j], ref data[j + gap]);
                    }
                }
            }

        }

        /// <summary>
        ///直接选择排序
        ///直接选择其他部分最小的和当前位置的进行交换
        /// </summary>
        /// <param name="data"></param>
        public void DirectSelectSort(int[] data)
        {
            int i, j, minIndex;
            int len = data.Length;
            for (i = 0; i < len; i++)
            {
                minIndex = i;
                //找到最小值
                for (j = i + 1; j < len; j++)
                {
                    if (data[j] < data[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(ref data[i], ref data[minIndex]);
            }
        }

        /// <summary>
        /// 归并排序
        /// 分治法
        /// 分别将两个已经排序好的序列分别插入到第三个序列中
        /// </summary>
        public void MergeSort(int[] a)
        {
            MergeSort(a, 0, a.Length - 1);
        }

        private void MergeSort(int[] a, int first, int last)
        {
            if (first < last)
            {
                int mid = (first + last) / 2;
                MergeSort(a, first, mid);//left
                MergeSort(a, mid + 1, last);//right
                MergeTwoArray(a, first, mid, last);
            }
        }

        private void MergeTwoArray(int[] data, int first, int mid, int last)
        {
            int i, j, k;
            i = first;
            j = mid + 1;
            k = 0;
            int m = mid;
            int n = last;

            int[] temp = new int[data.Length];

            while (i <= m && j <= n)
            {
                if (data[i] <= data[j])
                {
                    temp[k] = data[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = data[j];
                    k++;
                    j++;
                }

            }

            while (i <= m)
            {
                temp[k] = data[i];
                k++; i++;
            }
            while (j <= n)
            {
                temp[k] = data[j];
                k++; j++;
            }


            for (int index = 0; index < k; index++)
            {
                data[first + index] = temp[index];
            }

        }

        /// <summary>
        /// 快速排序
        /// </summary>
        /// 挖坑填数+分治
        /// 1.从数组中选择一个数作为基数（第一个）
        /// 2.分区，将比它大的分左边，比它小的分右边
        /// 3.对左右分区重复第2步，直到分区只有一个数
        public void QuickSort(int[] data)
        {
            QuickSortAdjust(data, 0, data.Length - 1);
        }

        private void QuickSortAdjust(int[] data, int left, int right)
        {
            if (left < right)
            {
                int i = left, j = right;
                int x = data[left];
                while (i < j)
                {
                    //from right to left to find less than x
                    while (i < j && data[j] >= x)
                    {
                        j--;
                    }
                    if (i < j)
                    {
                        data[i] = data[j];
                        j--;
                    }

                    //from left to right to find more than x
                    while (i < j && data[i] < x)
                    {
                        i++;
                    }
                    if (i < j)
                    {
                        data[j] = data[i];
                        j--;
                    }
                }



            }

        }






    }
}
