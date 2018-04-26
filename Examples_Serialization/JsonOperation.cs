using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Examples_Serialization
{
    static class JsonOperation
    {
        private static Person p;
        private static List<Person> ps;
        static JsonOperation()
        {
            p = new Person
            {
                Name="Jack",
                Age=30,
                Major="CS"
            };
            ps = new List<Person>();
            ps.Add(p);
            ps.Add(p);
            ps.Add(p);
        }
        public static void JSS()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string json = js.Serialize(p);
            Console.WriteLine(json);
            Console.WriteLine("Serialization Done");

            Person new_p = js.Deserialize<Person>(json);
            Console.WriteLine(new_p.Name);

        }


        public static void DCJS()
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Person));
            MemoryStream ms = new MemoryStream();
            js.WriteObject(ms,p);
            ms.Position = 0;
            string json = Encoding.Default.GetString(ms.ToArray());
            Console.WriteLine(json);

            MemoryStream ms_new = new MemoryStream(Encoding.Default.GetBytes(json));
            Person pp = js.ReadObject(ms_new) as Person;
            Console.WriteLine(pp.Name);
        }

        public static void NewtonJson()
        {
            var json = JsonConvert.SerializeObject(p);
            Console.WriteLine(json);

            var pp = JsonConvert.DeserializeObject<Person>(json);
            Console.WriteLine(pp.Name);


            var jobj = JsonConvert.DeserializeObject(json) as JObject;
            Console.WriteLine(jobj.GetType());
            foreach (var item in jobj)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }




        }

        public static void NewtonJsonLinq()
        {
            var json = JsonConvert.SerializeObject(ps);
            Console.WriteLine(json);

            dynamic persons = JsonConvert.DeserializeObject<dynamic>(json);
            foreach (var item in persons)
            {
                Console.WriteLine(item.Name);
            }

        }



    }
}
