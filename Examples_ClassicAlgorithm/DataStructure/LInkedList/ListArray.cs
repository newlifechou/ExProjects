using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.LInkedList
{
    /// <summary>
    /// implement a list by using array
    /// suitable to read,not to insert or delete
    /// </summary>
    class ListArray : IList
    {
        //the length of the array for stored
        private readonly int maxSize;
        //use an array to store list data
        //no automatic increase the capacity
        private string[] StoredData;
        //the length of listarray
        private int listLength = 0;

        public ListArray()
        {
            this.maxSize = 20;
            StoredData = new string[maxSize];
        }

        public ListArray(int maxSize)
        {
            this.maxSize = maxSize;
            StoredData = new string[maxSize];
        }


        public void Add(string data)
        {
            //consider if the maxSize is out of range.
            if (listLength < maxSize)
            {
                StoredData[listLength] = data;
                listLength++;
            }
        }

        public void Clear()
        {
            listLength = 0;
        }

        public string GetData(int index)
        {
            if (index >= listLength || index < 0)
                throw new IndexOutOfRangeException();
            return StoredData[index];
        }

        public int GetLength()
        {
            return listLength;
        }

        public int IndexOf(string data)
        {
            for (int i = 0; i < listLength; i++)
            {
                if (StoredData[i] == data)
                    return i;
            }
            return -1;
        }

        public void Insert(int index, string data)
        {
            if (index < listLength && index >= 0)
            {
                for (int i = listLength - 1; i >= index; i--)
                {
                    StoredData[i + 1] = StoredData[i];
                }
                StoredData[index] = data;
                listLength++;
            }
        }

        public bool IsEmpty()
        {
            return listLength == 0;
        }

        public void Remove(string data)
        {
            for (int i = 0; i < listLength; i++)
            {
                if (StoredData[i] == data)
                {
                    //for (int j = i; j < listLength - 1; j++)
                    //{
                    //    StoredData[i] = StoredData[i + 1];
                    //}
                    for (int j = i + 1; j < listLength; j++)
                    {
                        StoredData[i - 1] = StoredData[i];
                    }
                    listLength--;
                    break;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= listLength || index < 0)
                throw new IndexOutOfRangeException();

            for (int i = index; i < listLength - 1; i++)
            {
                StoredData[i] = StoredData[i + 1];
            }
            listLength--;
        }
    }
}
