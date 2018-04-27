using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Examples_Serialization.Model
{

    /// <summary>
    /// 使用json特性
    /// </summary>
    [JsonObject]
    public class Dog
    {
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public int Age { get; set; }
        [JsonProperty]
        public string Special { get; set; }
        [JsonExtensionData]
        public string[] FavoriteFood { get; set; }
        public Dictionary<string,string> Experienments { get; set; }
    }
}
