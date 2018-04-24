using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Url
{
    class Program
    {
        static void Main(string[] args)
        {
            string encode_str = System.Web.HttpUtility.UrlEncode("hello world", Encoding.UTF8);
            Console.WriteLine(encode_str);
            Console.Read();
        }
    }
}
