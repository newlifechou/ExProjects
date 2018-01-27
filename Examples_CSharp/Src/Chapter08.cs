using Examples_CSharp.Src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples_CSharp.Src
{
    /// <summary>
    /// 匿名类型
    /// </summary>
    class Chapter08
    {
        public void Test1()
        {
            var p = new Product { Name = "Photoshop", Price = 5000 };

        }

        public void Test2()
        {
            var products = new List<Product>();

            var newTypeOfProducts = products.ConvertAll(i =>
            {
                return new { ProductName = i.Name, ProductPrice = i.Price };
            });

            newTypeOfProducts.ForEach(i =>
            {
                Console.WriteLine(i.ProductName + i.ProductPrice);
            });


        }

    }
}
