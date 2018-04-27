using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.QRCode;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;

namespace Examples_QRCode
{
    /// <summary>
    /// 演示如何使用该类库实现二维码的生成和解析
    /// 需要引用对应的Thoughtworks.QRCode.dll
    /// </summary>
    static class ThoughtworksQRCodeOperation
    {
        public static void EnCodeToQRCodeImage(string qr_str)
        {
            QRCodeEncoder qr = new QRCodeEncoder();
            qr.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qr.QRCodeScale = 4;
            qr.QRCodeVersion = 8;
            qr.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;

            var image = qr.Encode(qr_str);

            FileStream fs = new FileStream("qr.jpg",FileMode.Create);
            image.Save(fs, ImageFormat.Jpeg);
            Console.WriteLine("二维码生成OK");
            fs.Close();
        }

        public static void DeCodeFromQRCodeImage(string image)
        {
            if (!File.Exists(image))
                return;

            Bitmap bmp = new Bitmap(Image.FromFile(image));
            QRCodeDecoder decoder = new QRCodeDecoder();
            string qr_str = decoder.decode(new QRCodeBitmapImage(bmp));
            Console.WriteLine($"解析出来的字符串是：{qr_str}");
        }




    }
}
