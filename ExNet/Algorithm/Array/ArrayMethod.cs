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
            if (data.Length==0)
            {
                return -1;
            }
            int max = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i]>max)
                {
                    max = data[i];
                }
            }
            return max;
        }
    }
}
