using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Serialization.Model
{
    public class School
    {
        public string Name { get; set; }
        public List<Person> persons { get; set; }
    }
}
