using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Encode
{
    public class XSEncode
    {
        public string Base64Encode(string source)
        {
            string encode = string.Empty;

            byte[] bytes = Encoding.UTF8.GetBytes(source);

            encode = Convert.ToBase64String(bytes);
            return encode;
        }


        public string Base64Decode(string base64_str)
        {
            string decode_str = "";

            byte[] bytes = Convert.FromBase64String(base64_str);

            decode_str = Encoding.UTF8.GetString(bytes);
            return decode_str;
        }

        public void DisplayBytesInNumbers(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.Write($"{bytes[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.Write($"{(char)bytes[i]} ");
            }
            Console.WriteLine();
        }


    }
}
