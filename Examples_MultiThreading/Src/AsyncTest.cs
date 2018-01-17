using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace MultiThreading.Src
{
    class AsyncTest
    {
        public void Two()
        {
            Console.WriteLine("任务Main开始");
            Task task = new Task(One);
            task.Start();
            Thread.Sleep(1000);
            Console.WriteLine("任务Main结束");

        }
        public async void One()
        {
            Console.WriteLine("任务One开始");
            Thread.Sleep(2000);
            HttpClient client = new HttpClient();
            Task<string> task = client.GetStringAsync("http://www.cdpmi.net");
            string contents = await task;
            Console.WriteLine(contents);
            Console.WriteLine("任务One结束");

        }

    }
}
