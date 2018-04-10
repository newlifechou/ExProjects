using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.LInkedList
{
    class ListCircleOneWay : IList
    {
        private Node header;
        private Node slider;
        private int length;
        public ListCircleOneWay()
        {
            length = 0;

            header = new Node();
            header.next = header;
            slider = header;
        }

        public Node GetCurrent()
        {
            return slider;
        }

        public Node GetNext()
        {
            Node result = slider.next;
            slider = slider.next;
            return result;
        }


        public void Append(string data)
        {
            Node newNode = new Node(data);
            //insert after the header
            newNode.next = header.next;
            header.next = newNode;

            length++;
        }

        public void Clear()
        {
            header.next = header;
            slider = header;
        }

        public string GetData(int index)
        {
            throw new NotImplementedException();
        }

        public int GetLength()
        {
            return length;
        }

        public int IndexOf(string data)
        {
            throw new NotImplementedException();
        }

        public void Initialize(int n)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, string data)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return length > 0;
        }

        public void Remove(string data)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
