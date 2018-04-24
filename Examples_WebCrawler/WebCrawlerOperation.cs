using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Examples_WebCrawler
{
    public static class WebCrawlerOperation
    {
        /// <summary>
        /// 使用WebRequest
        /// 同步方式
        /// </summary>
        public static void UseWebRequest()
        {
            string url = @"http://www.cd-pmi.com";
            WebRequest request = WebRequest.Create(url);
            WebResponse response = (WebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(dataStream, Encoding.UTF8);

            string content = sr.ReadToEnd();
            Console.WriteLine(content);
        }

        public async static void UseWebRequestAsync()
        {
            string url = @"http://www.cd-pmi.com";
            WebRequest request = WebRequest.Create(url);
            var task = await request.GetResponseAsync();
            WebResponse response = task;
            Stream dataStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(dataStream, Encoding.UTF8);

            string content = await sr.ReadToEndAsync();

            Console.WriteLine(content);
        }

        public static void UseHttpWebRequest()
        {
            string url = @"http://www.cd-pmi.com";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.84 Safari/537.36";
            request.Method = "GET";
            request.Referer = "http://www.cd-pmi.com";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string content = sr.ReadToEnd();
            Console.WriteLine(content);
        }

        public static void UseWebClient()
        {
            WebClient client = new WebClient();
            client.Credentials = CredentialCache.DefaultCredentials;
            byte[] pageData = client.DownloadData("http://www.cd-pmi.com");
            string content = Encoding.UTF8.GetString(pageData);
            Console.WriteLine(content);
        }


    }
}
