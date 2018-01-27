using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewStuff
{
    class Interview01
    {
        public void Test01()
        {
            const int max = 10;
            Random rand = new Random();
            int[] data = new int[max];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(1, max);
            }
            data.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();
            Sort(data, true);
            data.ToList().ForEach(Console.WriteLine);
            Sort(data, false);
            data.ToList().ForEach(Console.WriteLine);
        }

        private void Sort(int[] data, bool isAssending)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (isAssending)
                    {
                        if (data[j] > data[j + 1])
                        {
                            int tmp = data[j];
                            data[j] = data[j + 1];
                            data[j + 1] = tmp;
                            data.ToList().ForEach(k => Console.Write($"{k} "));
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        if (data[j] < data[j + 1])
                        {
                            int tmp = data[j];
                            data[j] = data[j + 1];
                            data[j + 1] = tmp;
                            data.ToList().ForEach(k => Console.Write($"{k} "));
                            Console.WriteLine();
                        }
                    }
                }
            }

        }

    }
}
