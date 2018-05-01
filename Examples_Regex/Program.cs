using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = @"abchttp://www.163.com23424 xs.zhou@outlook.com adfafda2012-12-12sdfasdfadfadf";
            //string p = @"\d{4}-\d{1,2}-\d{1,2}";
            //RegexOperation.RegexMatches(s, p);


            string phone_number = "13540781788";
            string pattern = @"(\d{3})\d{4}(\d{4})";
            string replace = @"$1****$2";
            string result=RegexOperation.Replace(phone_number, pattern, replace);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
