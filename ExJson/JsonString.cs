using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

using System.IO;

namespace ExJson
{
    public class JsonString
    {
        public JsonString()
        {
            SimpleJson = "{\"Name\":\"xs.zhou\",\"Score\":99}";
        }
        public string SimpleJson { get; set; }

        public void Test1()
        {
            Person p = new Person();
            p.Name = "Jack Paul";
            p.Score = 99;

            DataContractSerializer dcs = new DataContractSerializer(typeof(Person));
            MemoryStream ms = new MemoryStream();
            dcs.WriteObject(ms, p);
            ms.Position = 0;

            StreamReader sr = new StreamReader(ms, Encoding.UTF8);
            string json = sr.ReadToEnd();
            sr.Close();
            ms.Close();
            Console.WriteLine(json);

            DataContractJsonSerializer djson = new DataContractJsonSerializer(typeof(Person));
            MemoryStream ms2 = new MemoryStream();
            djson.WriteObject(ms2, p);
            ms2.Position = 0;

            StreamReader sr2 = new StreamReader(ms2, Encoding.UTF8);
            string json2 = sr2.ReadToEnd();
            Console.WriteLine(json2);
            sr2.Close();
            ms2.Close();

        }



    }
}
