using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


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

        public void Single()
        {
            MemoryStream ms = new MemoryStream();
            StreamWriter writer = new StreamWriter(ms);
            XmlSerializer serializer = new XmlSerializer(typeof(Passport));
            serializer.Serialize(writer, single);
            byte[] bytes = ms.ToArray();

            string xml_text = Encoding.UTF8.GetString(bytes);
            Console.WriteLine(xml_text);

            Passport p = (Passport)serializer.Deserialize(new XmlTextReader(ms));

            Console.WriteLine(p.Name);
        }




    }
}
