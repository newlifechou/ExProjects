using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Array
{
    public class NumberMethod
    {
        public bool ThreeEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }
        public bool BetweenZeroAndOne(double a, double b)
        {
            return a > 0 && a < 1 && b > 0 && b < 1;
        }

        public string TenToBinary(int a)
        {
            string s = "";
            for (int n = a; n > 0; n /= 2)
            {
                s = (n % 2) + s;
            }
            return s;
        }
        //TODO:后续实现10到8，10到16，2到10，8到10，16到10

        public string TenToOct(int a)
        {
            throw new NotImplementedException();
        }

        public string TenToHex(int a)
        {
            throw new NotImplementedException();
        }

        public int BinaryToTen(string a)
        {
            throw new NotImplementedException();
        }

        public int OctToTen(string a)
        {
            throw new NotImplementedException();
        }

        public int HexToTen(string a)
        {
            throw new NotImplementedException();
        }

        public int lg(int n)
        {
            int m = 1;
            int ss = 1;
            while (m<n)
            {
                ss *= 2;
                if (ss>=n)
                {
                    break;
                }
                m++;
            }
            return m-1;
        }



    }
}
