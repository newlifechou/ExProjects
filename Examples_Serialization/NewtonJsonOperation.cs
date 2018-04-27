using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples_Serialization.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Examples_Serialization
{
    public static class NewtonJsonOperation
    {
        public static void Primitive()
        {
            int i = 10;
            string name = "jack";
            DateTime dt = DateTime.Now;
            string json = JsonConvert.SerializeObject(new { Name = name, Count = i, Date = dt });
            Console.WriteLine(json);
        }

        public static void List()
        {
            var cats = new List<Cat>();
            for (int i = 0; i < 10; i++)
            {
                cats.Add(new Cat { Name = "ketty", Age = i + 1, Owner = "jack" });
            }

            string json = JsonConvert.SerializeObject(cats);
            Console.WriteLine(json);
        }


        public static void Dict()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "hello1");
            dict.Add(2, "hello2");

            string json = JsonConvert.SerializeObject(dict);
            Console.WriteLine(json);

        }

        public static void Nested()
        {
            School school = new School();
            school.Name = "Junior School";
            var ps = new List<Person>();
            ps.Add(new Person { Name = "jack1", Age = 28 });
            ps.Add(new Person { Name = "jack2", Age = 29 });
            ps.Add(new Person { Name = "jack3", Age = 30 });

            school.persons = ps;

            string json = JsonConvert.SerializeObject(school);
            Console.WriteLine(json);

        }

        public static void DeserializeNested()
        {
            string json_str = File.ReadAllText("book.json");
            //Console.WriteLine(json_str);
            var book = JsonConvert.DeserializeObject<BookModel>(json_str);
            Console.WriteLine(book.publisher);
        }

        public static void Dynamic()
        {
            var obj = new { Name = "jack", Age = 28 };
            string json = JsonConvert.SerializeObject(obj);
            var person = JsonConvert.DeserializeObject<dynamic>(json);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }

        /// <summary>
        /// 使用linq to json
        /// </summary>
        public static void JsonLinq()
        {
            string json = File.ReadAllText("book.json");
            var obj = JObject.Parse(json);
            string title = (string)obj["title"];
            Console.WriteLine(title);
            string author1 = (string)obj["author"][0];
            Console.WriteLine(author1);

            var tags = obj["tags"].Select(r => (string)r["title"]).ToList();
            foreach (var item in tags)
            {
                Console.WriteLine(item);
            }
        }

        public static void LoadFromJsonFile()
        {
            string file = "book.json";
            using (var reader = File.OpenText(file))
            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                string title = (string)o["title"];
                Console.WriteLine(title);
            }
        }

        /// <summary>
        /// Manually creating json
        /// </summary>
        public static void CreateJsonByHand()
        {
            JArray array = new JArray();
            JValue text = new JValue("Jack Paul");
            JValue date = new JValue(new DateTime(2018, 5, 23));
            array.Add(text);
            array.Add(date);
            string json = array.ToString();
            Console.WriteLine(json);
        }


        public static void CreateJsonByLinq()
        {
            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat { Name = "ketty1", Age = 2 });
            cats.Add(new Cat { Name = "ketty2", Age = 2 });
            cats.Add(new Cat { Name = "ketty3", Age = 2 });
            cats.Add(new Cat { Name = "ketty4", Age = 2 });
            JObject rss = new JObject(
                    new JProperty("name", "jack"),
                    new JProperty("age", 20),
                    new JProperty("books",
                        new JArray(
                            from c in cats
                            orderby c.Name
                            select new JObject(
                                new JProperty("name", c.Name),
                                new JProperty("age", c.Age)))));

            Console.WriteLine(rss);
        }

        public static void CreateJsonFromObj()
        {
            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat { Name = "ketty1", Age = 2 });
            cats.Add(new Cat { Name = "ketty2", Age = 2 });
            cats.Add(new Cat { Name = "ketty3", Age = 2 });
            cats.Add(new Cat { Name = "ketty4", Age = 2 });

            JObject o = JObject.FromObject(new
            {
                cats = new
                {
                    title = "jack",
                    link = "http://www.douban.com",
                    item = from c in cats
                           select new
                           {
                               name = c.Name,
                               age = c.Age
                           }
                }
            });

            Console.WriteLine(o.ToString());
        }


    }
}
