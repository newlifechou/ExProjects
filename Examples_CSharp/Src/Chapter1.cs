using Examples_CSharp.Src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_CSharp.Src
{
    /// <summary>
    /// C# in depth
    /// </summary>
    class Chapter1
    {
        private List<Product> products = new List<Product>();



        public void UseLinq()
        {
            /*
             复杂的查询条件如果用扩展方法会很难读
             */
            var filetered = from p in products
                            where p.Price > 0
                            select p;
        }

        public void UseExtendMethods()
        {
            var result = products.Where(i => i.Price > 100);
        }


        public void UseNamedParameters()
        {
            //使用命名实参
            Display("Sql Server", 2000);
            Display(price: 20, product: "Visual Studio");
            Display(product: "Visual Studio Code", price: 2300);
        }

        private void Display(string product, double price)
        {

        }

    }
}
