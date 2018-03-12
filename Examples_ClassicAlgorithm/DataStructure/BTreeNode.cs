using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure
{
    public class BTreeNode<T>
    {
        public T data;
        public BTreeNode<T> LChild { get; set; }
        public BTreeNode<T> RChild { get; set; }
    }
}
