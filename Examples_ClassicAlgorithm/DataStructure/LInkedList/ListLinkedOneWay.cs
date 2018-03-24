using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.LInkedList
{
    /// <summary>
    /// 单向链表
    /// </summary>
    public class ListLinkedOneWay : IList
    {
        //head node, no data inside,its next node is the first node
        private Node head;
        public ListLinkedOneWay()
        {
            head = new Node();
        }

        public void Initialize(int n)
        {
            //append new node
            Node pointer = new Node();
            pointer = head;
            for (int i = 0; i < n; i++)
            {
                Node newNode = new Node("");
                pointer.next = newNode;
                pointer = pointer.next;
            }
        }

        public void InitializeAfterHead(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Node newNode = new Node("");
                newNode.next = head.next;
                head.next = newNode;
            }
        }

        public void Append(string data)
        {
            Node newNode = new Node(data);

            Node pointer = new Node();
            pointer = head;
            while (pointer.next != null)
            {
                pointer = pointer.next;
            }

            pointer.next = newNode;
        }

        public void Clear()
        {
            head.next = null;
        }

        public string GetData(int index)
        {
            if (IsEmpty())
                throw new NullReferenceException("empty list");

            Node pointer = new Node();
            pointer = head;
            int count = 0;
            while (pointer.next != null && count < index)
            {
                pointer = pointer.next;
                count++;
            }

            if (count == index)
            {
                return pointer.data;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        public int GetLength()
        {
            if (IsEmpty())
                return 0;

            Node pointer = new Node();
            pointer = head;
            int count = 0;
            while (pointer.next != null)
            {
                pointer = pointer.next;
                count++;
            }

            return count;
        }

        public int IndexOf(string data)
        {
            if (IsEmpty())
                return -1;
            Node pointer = new Node();
            pointer = head;

            int count = 0;
            while (pointer.next != null)
            {
                pointer = pointer.next;
                if (pointer.data == data)
                {
                    return count;
                }
                count++;
            }
            return -1;
        }

        public void Insert(int index, string data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                head.next = newNode;
                return;
            }

            Node pointer = new Node();
            pointer = head;

            int count = 0;
            while (pointer.next != null && count < index - 1)
            {
                pointer = pointer.next;
                count++;
            }

            //insert
            if (count == index - 1)
            {
                newNode.next = pointer.next;
                pointer.next = newNode;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        public bool IsEmpty()
        {
            return head.next == null;
        }

        public void Remove(string data)
        {
            if (head.next == null)
                return;

            //sibling pointers
            Node pointer1 = new Node();
            Node pointer2 = new Node();
            pointer1 = head;
            pointer2 = head.next;
            while (pointer2.next != null)
            {
                if (pointer2.data == data)
                {
                    pointer1.next = pointer2.next;
                    break;
                }
                pointer1 = pointer1.next;
                pointer2 = pointer2.next;
            }


        }

        public void RemoveAt(int index)
        {
            if (head.next == null)
                return;

            //sibling pointers
            Node pointer1 = new Node();
            Node pointer2 = new Node();
            pointer1 = head;
            pointer2 = head.next;
            int count = 0;
            while (pointer2.next != null)
            {
                //find the location
                if (count==index)
                {
                    pointer1.next = pointer2.next;
                    break;
                }
                pointer1 = pointer1.next;
                pointer2 = pointer2.next;
                count++;
            }
        }
    }
}
