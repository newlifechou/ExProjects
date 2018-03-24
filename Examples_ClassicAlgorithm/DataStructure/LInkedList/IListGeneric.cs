using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_ClassicAlgorithm.DataStructure.LInkedList
{
    public interface IListGeneric<T>
    {
        /// <summary>
        /// initialize n elements
        /// </summary>
        /// <param name="n"></param>
        void Initialize(int n);

        bool IsEmpty();

        void Append(T data);
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="index">从0开始</param>
        /// <param name="data"></param>
        void Insert(int index, T data);

        void Clear();
        void RemoveAt(int index);
        void Remove(T data);

        T GetData(int index);
        int IndexOf(T data);

        int GetLength();
    }
}
