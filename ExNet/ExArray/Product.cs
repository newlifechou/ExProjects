
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExArray
{
    public class Product:IComparable<Product>
    {
        public string Name { get; set; }
        public int CompareTo(Product other)
        {
            if (other==null)
            {
                throw new ArgumentNullException();
            }

            return this.Name.CompareTo(other.Name);
        }
    }
}
