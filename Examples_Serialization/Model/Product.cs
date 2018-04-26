using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Serialization.Model
{
    public class Product : ISerializable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
           
        }
    }
}
