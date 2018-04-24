using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Examples_WebCrawler
{
    static class HtmlHelperOperation
    {
        public static void StartUseHtmlAgilityPack()
        {
            //加载本地文件
            var doc = new HtmlDocument();
            doc.Load("Test.html");
          
            var value = doc.DocumentNode.Descendants("p");
            foreach (var item in value)
            {
                Console.WriteLine(item.InnerHtml);
            }

            var links = doc.DocumentNode.Descendants("a");
            foreach (var link in links)
            {
                Console.WriteLine(link.Attributes["href"].Value);
            }

        }


        public static void ResolveWebsite()
        {
            string url = @"http://www.cd-pmi.com/ch/index.html";
            var web = new HtmlWeb();
            web.AutoDetectEncoding = true;
            web.BrowserTimeout = new TimeSpan(0,0,5);
            var doc=web.Load(url);
            var values = doc.DocumentNode.Descendants("a");
            foreach (var item in values)
            {
                if (!string.IsNullOrWhiteSpace(item.InnerText))
                {
                    Console.WriteLine($"{item.InnerText}-{item.Attributes["href"].Value}");
                }
            }


        }

    }
}
