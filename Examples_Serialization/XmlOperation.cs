using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;

namespace Examples_Serialization
{
    class XmlOperation
    {
        private Passport single;
        public XmlOperation()
        {
            single = new Passport
            {
                Id = 1,
                Name = "xs.zhou",
                Age = 27,
                Nation = "China",
                BirthPlace = "China"
            };
        }

        public void SingleXml()
        {
            MemoryStream ms = new MemoryStream();

            XmlSerializer serializer = new XmlSerializer(typeof(Passport));
            serializer.Serialize(ms, single);
            serializer.Serialize(Console.Out, single);

            string xml_text = Encoding.Default.GetString(ms.ToArray());
            Console.WriteLine(xml_text);

            //移动游标很重要
            ms.Seek(0, SeekOrigin.Begin);

            Passport p = (Passport)serializer.Deserialize(new XmlTextReader(ms));

            Console.WriteLine(p.Name);
            Console.WriteLine("Job Done");
        }

        /// <summary>
        /// Product类必须标记Serializable
        /// </summary>

        public void SingleSoap()
        {
            //构建一个字符串写入器模拟写入流对象
            MemoryStream ms = new MemoryStream();
            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(ms, single);

            foreach (var item in ms.ToArray())
            {
                Console.Write((char)item);
            }

            ms.Seek(0, SeekOrigin.Begin);

            Passport p = soap.Deserialize(ms) as Passport;
            Console.WriteLine(p.Name);

            Console.WriteLine("DeSerialization from Soap Done");

        }

        public void SingleBinary()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, single);
            Console.WriteLine("Serialization to Binary Done");

            ms.Seek(0, SeekOrigin.Begin);

            Passport p = (Passport)formatter.Deserialize(ms);
            Console.WriteLine(p.Name);
            Console.WriteLine("DeSerialization from Binary Done");
        }
    }
}
