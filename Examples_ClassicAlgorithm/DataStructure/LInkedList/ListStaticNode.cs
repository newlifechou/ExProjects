using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.LInkedList
{
    /// <summary>
    /// list static node
    /// </summary>
    public class ListStaticNode
    {
        //indicate the next node position in array
        public int next;
        public string data;

        public ListStaticNode()
        {

        }
        public ListStaticNode(string data)
        {
            this.data = data;
        }
        public ListStaticNode(int next,string data)
        {
            this.next = next;
            this.data = data;
        }
    }
}
