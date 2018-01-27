using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_CSharp.Src
{
    /// <summary>
    /// yield
    /// </summary>
    class Chapter06 : IEnumerable<int>
    {
        private int[] data;
        public Chapter06()
        {
            int count = 10;
            data = new int[count];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i * i;
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
            throw new NotImplementedException();
        }
    }
}
