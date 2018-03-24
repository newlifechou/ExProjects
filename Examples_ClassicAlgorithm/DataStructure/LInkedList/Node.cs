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
            Data = data;
        }
        public Node(string data,Node next)
        {
            Data = data;
            Next = next;
        }
        public Node(string data,Node prev,Node next)
        {
            Data = data;
            Prev = prev;
            Next = next;
        }

        public string Data;
        public Node Prev;
        public Node Next;
    }
}
