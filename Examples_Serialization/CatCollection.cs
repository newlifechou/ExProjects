using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Examples_Serialization
{
    [XmlRoot]
    class CatCollection
    {
        [XmlArray, XmlArrayItem]
        public Cat[] Cats { get; set; }
    }
}
