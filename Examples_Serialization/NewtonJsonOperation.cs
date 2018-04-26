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










    }
}
