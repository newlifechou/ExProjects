using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_QRCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ThoughtworksQRCodeOperation.EnCodeToQRCodeImage("hello qrcode");
            ThoughtworksQRCodeOperation.DeCodeFromQRCodeImage("qr.jpg");
            Console.Read();
        }
    }
}
