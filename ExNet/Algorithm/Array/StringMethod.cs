using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Array
{
    public class StringMethod
    {

        public string exR1(int n)
        {
            if (n<=0)
            {
                return "S";
            }
            return exR1(n - 3) + n + exR1(n - 2) + n;
        }

        public  int exR2(int a,int b)
        {
            if (b==0)
            {
                return 0;
            }
            if (b%2==0)
            {
                return exR2(a + a, b/2);
            }
            return exR2(a + a, b / 2) + a;
        }

        public int exR3(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            if (b % 2 == 0)
            {
                return exR3(a * a, b / 2);
            }
            return exR3(a * a, b / 2) * a;
        }

















    }
}
