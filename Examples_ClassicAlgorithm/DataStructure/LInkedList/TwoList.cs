using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.LInkedList
{
    /// <summary>
    /// 两个线性表的操作
    /// </summary>
    class TwoList
    {
        //两个线性表La,Lb的操作
        ListArray La, Lb;

        public TwoList(ListArray a, ListArray b)
        {
            La = a;
            Lb = b;
        }

        //并集
        public void UnionToLa()
        {
            for (int i = 0; i < Lb.GetLength(); i++)
            {
                string dataB = Lb.GetData(i);
                //if not in La,add to La
                if (La.IndexOf(dataB) == -1)
                {
                    La.Add(dataB);
                }
            }
        }

        //合集
        public void Collection()
        {
            for (int i = 0; i < Lb.GetLength(); i++)
            {
                La.Add(Lb.GetData(i));
            }
        }

        //交集A-B
        public ListArray Intersection()
        {
            ListArray Lc = new ListArray();
            for (int i = 0; i < La.GetLength(); i++)
            {
                string current = La.GetData(i);
                if (Lb.IndexOf(current) != -1)
                {
                    Lc.Add(current);
                }
            }
            return Lc;
        }


        /// <summary>
        /// Combine Two Ordered List together in right order.
        /// from small to large
        /// </summary>
        /// <returns></returns>
        public ListArray UnionTwoSorted()
        {
            int lengthA = La.GetLength();
            int lengthB = Lb.GetLength();

            ListArray Lc = new ListArray(lengthA + lengthB);

            int indexA = 0, indexB = 0;
            while (indexA < lengthA && indexB < lengthB)
            {
                string currentA = La.GetData(indexA);
                string currentB = Lb.GetData(indexB);
                //If currentA is smaller
                if (string.Compare(currentA, currentB) < 0)
                {
                    Lc.Add(currentA);
                    indexA++;
                }
                else
                {
                    Lc.Add(currentB);
                    indexB++;
                }
            }

            if (indexA==lengthA)
            {
                for (int i = indexB; i < lengthB; i++)
                {
                    Lc.Add(Lb.GetData(i));
                }
            }

            if(indexB==lengthB)
            {
                for (int i = indexA; i < lengthA; i++)
                {
                    Lc.Add(La.GetData(i));
                }
            }

            return Lc;
        }

    }
}
