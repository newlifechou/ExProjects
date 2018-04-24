using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Examples_WebCrawler
{
    public static class WallpaperDownloader
    {
        private static string url_prefix = @"http://desk.zol.com.cn/bizhi/7277_8999";
        public static void Download()
        {
            for (int i = 0; i < 9; i++)
            {
                var newUrl = $"{url_prefix}{i + 1}_2.html";
                GetImageLink(newUrl);
            }
            System.Diagnostics.Process.Start(Environment.CurrentDirectory);
        }

        public static void GetImageLink(string url)
        {
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var images = doc.DocumentNode.SelectNodes("//img[@id='bigImg']");
            foreach (var item in images)
            {
                string img_url = item.Attributes["src"].Value;
                Console.WriteLine(img_url);
                string image_name = img_url.Split(new char[] { '/' },
                    StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
                DownloadImage(img_url,image_name);
            }
        }

        public static void DownloadImage(string imgUrl,string current_filename)
        {
            using (WebClient wc=new WebClient())
            {
                wc.DownloadFile(imgUrl, current_filename);
            }
        }
    }
}
