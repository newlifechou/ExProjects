using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.LInkedList
{
    /// <summary>
    /// Normal Node
    /// contains a string type data
    /// prev and next reference
    /// </summary>
    public class Node
    {
        public Node()
        {

        }
        public Node(string data)
        {
            this.data = data;
            this.next = null;
        }
        public Node(string data,Node next)
        {
            this.data = data;
            this.prev = null;
            this.next = next;
        }
        public Node(string data,Node prev,Node next)
        {
            this.data = data;
            this.prev = prev;
            this.next = next;
        }

        public string data;
        public Node prev;
        public Node next;
    }
}
