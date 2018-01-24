using Examples_CSharp.Src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examples_CSharp.Src
{
    /// <summary>
    /// C# in depth
    /// </summary>
    class Chapter01
    {
        private List<Product> products = new List<Product>();
        private List<Supplier> suppliers = new List<Supplier>();

        public void UseDynamic()
        {
            //Later
        }

        public void UseLinq()
        {
            /*
             *Linq只是借鉴了sql 
             *复杂的查询条件如果用扩展方法会很难读
             */
            var result1 = from p in products
                            where p.Price > 0
                            select p;

            //join,filter,order,project
            var result2 = from p in products
                          join s in suppliers
                          on p.SupplierId equals s.Id
                          where p.Price > 10
                          orderby s.Name, p.Name
                          select new { SupplierName = s.Name, ProductName = p.Name };
            //query xml
            XDocument doc = XDocument.Load("data.xml");
            var result3 = from p in doc.Descendants("product")
                          where (double)p.Attribute("Price") > 10
                          select new { ProductName = p.Attribute("Name") };


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
