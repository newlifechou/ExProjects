using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Examples_WebCrawler
{
    public static class WebOperation
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

        public async static void UseWebReqeustAsync()
        {
            string url = @"http://www.cd-pmi.com";
            WebRequest request = WebRequest.Create(url);
            var task = await request.GetResponseAsync();
            WebResponse response = task;
            Stream dataStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(dataStream, Encoding.UTF8);

            string content =await sr.ReadToEndAsync();
            Console.WriteLine(content);
        }

    }
}
