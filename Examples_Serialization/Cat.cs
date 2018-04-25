using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Examples_Serialization
{
    [XmlRoot]
    class Cat
    {
        [XmlElement]
        public string Name { get; set; }
        [XmlAttribute]
        public int Age { get; set; }
        [XmlIgnore]
        public string Owner { get; set; }
    }
}
