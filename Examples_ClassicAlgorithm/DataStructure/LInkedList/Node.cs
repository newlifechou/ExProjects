using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.LInkedList
{

    public class Node
    {
        public Node()
        {

        }
        public Node(string data)
        {
            this.data = data;
        }
        public Node(string data,Node next)
        {
            this.data = data;
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
