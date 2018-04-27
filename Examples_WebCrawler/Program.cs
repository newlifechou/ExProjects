using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_WebCrawler
{  
    class Program
    {
        static void Main(string[] args)
        {
            //WebCrawlerOperation.UseWebClient();
            //HtmlHelperOperation.ResolveWebsite();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Task task = Task.Factory.StartNew(WebApiOperation.GetWeather);


            Console.WriteLine("主线程任务继续执行");
            Console.Read();
        }
    }
}
