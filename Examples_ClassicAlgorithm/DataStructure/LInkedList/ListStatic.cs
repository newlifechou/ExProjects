using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.LInkedList
{
    class ListStatic : IList
    {
        private readonly int maxSize;
        private ListStaticNode[] StoredData;
        public ListStatic()
        {
            maxSize = 1000;
            StoredData = new ListStaticNode[maxSize];
            //first free position
            StoredData[0].next = 1;
            //first data position
            StoredData[maxSize - 1].next = 0;
        }

        public void Append(string data)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public string GetData(int index)
        {
            throw new NotImplementedException();
        }

        public int GetLength()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(string data)
        {
            throw new NotImplementedException();
        }

        public void Initialize(int n)
        {
            //first linking loop
            for (int i = 0; i < maxSize - 1; i++)
            {
                StoredData[i].next = i + 1;
            }
            StoredData[maxSize - 1].next = 0;



            //max=maxSize-2
            if (n < maxSize - 2)
            {
                for (int i = 0; i < n; i++)
                {
                    int currentPosition = StoredData[0].next;
                    StoredData[currentPosition].data = "ok";

                    //set first free node again
                    StoredData[0].next = StoredData[currentPosition].next;
                }
                //set first data node
                StoredData[maxSize - 1].next = 1;
            }
        }

        public void Insert(int index, string data)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
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
