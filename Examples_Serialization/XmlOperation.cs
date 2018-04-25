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
            StreamWriter writer = new StreamWriter(ms,Encoding.UTF8);

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            XmlSerializer serializer = new XmlSerializer(typeof(Passport));
            serializer.Serialize(writer, single,ns);
            serializer.Serialize(Console.Out, single, ns);

            //string xml_text = Encoding.Default.GetString(ms.ToArray());
            //Console.WriteLine(xml_text);

            //移动游标很重要
            ms.Seek(0, SeekOrigin.Begin);

            Passport p = (Passport)serializer.Deserialize(new XmlTextReader(ms));

            Console.WriteLine(p.Name);
            Console.WriteLine("Job Done");
        }




    }
}
