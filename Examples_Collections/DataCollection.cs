using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_Collections
{
    class DataCollection : IEnumerable<int>
    {
        private int[] data;
        public DataCollection()
        {
            data = new int[10];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < data.Length; i++)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }
}
