using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExJson
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonString js = new ExJson.JsonString();
            js.DataSerializeJson();
            js.DataSerializeXML();
            js.JavaScriptJsonSerializer();

            Console.Read();
        }
    }
}
