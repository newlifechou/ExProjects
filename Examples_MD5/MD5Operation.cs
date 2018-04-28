using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Examples_MD5
{
    class MD5Operation
    {
        public string GetMD5(string message, string salt = null)
        {
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            if (!string.IsNullOrEmpty(salt))
            {
                message += salt;
            }
            byte[] byteMessage = Encoding.Default.GetBytes(message);
            provider.ComputeHash(byteMessage);
            return Convert.ToBase64String(provider.Hash);
        }

    }
}
