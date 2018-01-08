using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewStuff
{
    public class GroupOne
    {
        #region 求以下表达式的值，写出您想到的一种或几种实现方法:1-2+3-4+……+m 
        public int One(int m)
        {
            int sum = 0;
            for (int i = 1; i <= m; i++)
            {
                if (i % 2 == 0)
                    sum -= i;
                else
                    sum += i;
            }
            return sum;
        }
        public int Two(int m)
        {
            if (m % 2 == 0)
                return -1 * (m / 2);
            else
                return -1 * ((m - 1) / 2) + m;
        }
        #endregion
    }
}
