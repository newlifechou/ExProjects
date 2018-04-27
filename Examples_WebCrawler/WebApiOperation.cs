using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Examples_WebCrawler.Model;

namespace Examples_WebCrawler
{
    static class WebApiOperation
    {
        public static void GetDoubanUser()
        {
            //need OAuth， failed now
            string url = @"http://api.douban.com/labs/bubbler/user/ahbei";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            var response = request.GetResponse();

            StreamReader sr = new StreamReader(response.GetResponseStream());
            string json = sr.ReadToEnd();
            Console.WriteLine(json);
        }

        public static void GetWeather()
        {
            string url = @"https://www.sojson.com/open/api/weather/json.shtml?city=北京";
            string json = GetResponseString(url).Result;
            //Console.WriteLine(json);

            var weather = JsonConvert.DeserializeObject<WeatherModel>(json);
            if (weather.status == 200)
            {
                Console.WriteLine("#####today#####");
                Console.WriteLine(weather.date);
                Console.WriteLine(weather.message);
                Console.WriteLine(weather.city);
                Console.WriteLine(weather.data.ganmao);
                Console.WriteLine(weather.data.wendu);

                Console.WriteLine("#####yesterday#####");
                Console.WriteLine(weather.data.yesterday.date);
                Console.WriteLine(weather.data.yesterday.sunrise);
                Console.WriteLine(weather.data.yesterday.high);
                Console.WriteLine(weather.data.yesterday.low);
                Console.WriteLine(weather.data.yesterday.sunset);
                Console.WriteLine(weather.data.yesterday.fx);
                Console.WriteLine(weather.data.yesterday.fl);
                Console.WriteLine(weather.data.yesterday.type);
                Console.WriteLine(weather.data.yesterday.notice);

                foreach (var item in weather.data.forecast)
                {
                    Console.WriteLine($"#####{item.date}#####");
                    Console.WriteLine(item.sunrise);
                    Console.WriteLine(item.high);
                    Console.WriteLine(item.low);
                    Console.WriteLine(item.sunset);
                    Console.WriteLine(item.fx);
                    Console.WriteLine(item.fl);
                    Console.WriteLine(item.type);
                    Console.WriteLine(item.notice);
                }
            }
            else if (weather.status == 400)
            {
                Console.WriteLine(weather.message);
            }


        }

        private async static Task<string> GetResponseString(string url)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);
            var response = await request.GetResponseAsync();

            StreamReader sr = new StreamReader(response.GetResponseStream());
            string json = sr.ReadToEnd();
            return json;
        }



    }
}
