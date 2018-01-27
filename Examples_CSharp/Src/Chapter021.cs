using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_CSharp.Src
{
    class Chapter021
    {

    }

    class CountingEnumerable : IEnumerable<int>
    {

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        int current = -1;
        public bool MoveNext()
        {
            current++;
            return current < 10;
        }
        public int Current { get { return current; } }
        public int IEnumerable.Current { get { return current; } }

    }


}
