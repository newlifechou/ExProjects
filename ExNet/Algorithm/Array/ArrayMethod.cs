using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Array
{
    public class ArrayMethod
    {
        public int FindMax(int[] data)
        {
            if (data.Length == 0)
                return -1;
            int max = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > max)
                    max = data[i];
            }
            return max;
        }

        public int Average(int[] data)
        {
            int sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            return sum / data.Length;
        }

        public int[] CopyArray(int[] data)
        {
            int[] another = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                another[i] = data[i];
            }
            return another;
        }

        public void Reverse(int[] data)
        {
            int n = data.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = data[i];
                data[i] = data[n - 1 - i];
                data[n - 1 - i] = temp;
            }
        }

        public void Matrix(int[][] a, int[][] b)
        {

        }
        /// <summary>
        /// 二分法查找
        /// </summary>
        /// <param name="key"></param>
        /// <param name="a">数组必须有序</param>
        /// <returns></returns>
        public int Rank(int key, int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid])
                {
                    hi = mid - 1;
                }
                else if (key > a[mid])
                {
                    lo = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        /// <summary>
        /// Print bool value
        /// </summary>
        /// <param name="data"></param>
        public void PrintBoolean(bool[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1).; j++)
                {
                    Console.Write(i + "," + j);
                    if (data[i, j] == true)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Rotate  Matrix
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int[,] Rotate(int[,] a)
        {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            int[,] b = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[j, i] = a[i, j];
                }
            }
            return b;
        }
















    }
}
