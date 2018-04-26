using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Serialization.Model
{
    public class CatShop
    {
        public CatShop()
        {
            Cats = new List<Cat>();
        }
        public string ShopName { get; set; }
        public List<Cat> Cats { get; set; }
    }
}
