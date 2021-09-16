using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Encode
{
    public class Tester
    {
        public void Run1()
        {
            var xs = new XSEncode();
            string s_encode = xs.Base64Encode("hello world");
            Console.WriteLine(s_encode);

            string s_decode = xs.Base64Decode(s_encode);
            Console.WriteLine(s_decode);
        }

        public void Run()
        {
            var xs = new XSEncode();
            xs.DisplayBytesInNumbers("hello world");
        }



    }
}
