﻿using System;
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
            WebOperation.UseWebReqeustAsync();

            Console.WriteLine("主线程任务继续执行");
            Console.Read();
        }
    }
}
