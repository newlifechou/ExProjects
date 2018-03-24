using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.LInkedList
{
    public interface IList
    {
        /// <summary>
        /// initialize n elements
        /// </summary>
        /// <param name="n"></param>
        void Initialize(int n);

        bool IsEmpty();

        void Append(string data);
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="index">从0开始</param>
        /// <param name="data"></param>
        void Insert(int index, string data);

        void Clear();
        void RemoveAt(int index);
        void Remove(string data);

        string GetData(int index);
        int IndexOf(string data);

        int GetLength();
    }
}
