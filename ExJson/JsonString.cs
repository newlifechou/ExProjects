using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

using System.Web.Script.Serialization;



namespace ExJson
{
    public class JsonString
    {
        public JsonString()
        {
            p = new Person { Name = "Jack Paul", Score = 95 };
        }
        private Person p;
        public void DataSerializeXML()
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(Person));
            MemoryStream ms = new MemoryStream();
            dcs.WriteObject(ms, p);
            ms.Position = 0;

            StreamReader sr = new StreamReader(ms, Encoding.UTF8);
            string json = sr.ReadToEnd();
            sr.Close();
            ms.Close();
            Console.WriteLine(json);



        }

        public void DataSerializeJson()
        {
            DataContractJsonSerializer djson = new DataContractJsonSerializer(typeof(Person));
            MemoryStream ms2 = new MemoryStream();
            djson.WriteObject(ms2, p);
            ms2.Position = 0;

            StreamReader sr2 = new StreamReader(ms2, Encoding.UTF8);
            string json2 = sr2.ReadToEnd();
            sr2.Close();
            ms2.Close();
            Console.WriteLine(json2);


            //De
            var ms = new MemoryStream(Encoding.Unicode.GetBytes(json2));
            DataContractJsonSerializer dcs = new DataContractJsonSerializer(typeof(Person));
            Person pp = (Person)dcs.ReadObject(ms);
            Console.WriteLine($"{pp.Name}-----{pp.Score}");
        }

        public void JavaScriptJsonSerializer()
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonData = jss.Serialize(p);
            Console.WriteLine(jsonData);
            //De
            dynamic modeldy = jss.Deserialize<dynamic>(jsonData);
            Console.WriteLine($"{modeldy["Name"]}----{modeldy["Score"]}");



        }
    }
}
