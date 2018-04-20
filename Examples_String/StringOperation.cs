using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_String
{
    /// <summary>
    /// 这个类里面展示关于String的各种操作
    /// </summary>
    class StringOperation
    {
        private string str_ready = "the brown fox jumps over the lazy dog";
        public void Replace()
        {
            string result = str_ready.Replace('b', 'g');
            string result2 = str_ready.Replace("brown", "red");

        }

        public void Remove()
        {
            string result = str_ready.Remove(5);
            string result2 = str_ready.Remove(2, 3);
        }

        public void SubString()
        {
            string result = str_ready.Substring(4);
            string result1 = str_ready.Substring(2,3);

        }

        public void Trim()
        {
            string result = str_ready.Trim();
            string result2 = str_ready.TrimEnd();
            string result3 = str_ready.TrimStart();
            string result4 = str_ready.Trim(new char[] { 'a' });
            //etc
        }
        public void ChangeCase()
        {
            string result = str_ready.ToLower();
            string result2 = str_ready.ToUpper();
        }

        public void IndexOf()
        {
            int result = str_ready.IndexOf("fox");
            int result2 = str_ready.IndexOf("fox", 0, 1, StringComparison.CurrentCultureIgnoreCase);
            int result3 = str_ready.IndexOfAny(new char[] { ' ', '-' }, 0, 1);
            int result4 = str_ready.LastIndexOf(' ');
            int result5 = str_ready.LastIndexOfAny(new char[] { ' ' });
        }

        public void Split()
        {
            string[] words = str_ready.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
        }

        public void Contains()
        {
            bool result = str_ready.Contains("fox");
        }

        public void StartEndWith()
        {
            bool result2 = str_ready.StartsWith("fox");
            bool result3 = str_ready.EndsWith("fox");
        }

        public void Insert()
        {
            string result = str_ready.Insert(1, "fuck");
        }

        public void Pad()
        {
            string result = str_ready.PadLeft(10);
            string result2 = str_ready.PadRight(10);
        }
    }
}
