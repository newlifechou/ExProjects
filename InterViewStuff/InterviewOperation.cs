using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterViewStuff
{
    class InterviewOperation
    {

        public static int count=0;
        static InterviewOperation()
        {
            count++;
        }

        public InterviewOperation()
        {
            count++;
        }
        /// <summary>
        /// 要求长度，随机，不能同时出现0或者O
        /// 每个字母获取的概率相同
        /// </summary>
        /// <param name="count"></param>
        public static void RandomValidationCode(int count)
        {
            string code = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string[] keyCode = code.Split(',');
            string validateCode = string.Empty;
            Random rand = new Random();
            #region 在这里完善你的代码
            bool canLoop = true;
            while (canLoop)
            {
                string a = keyCode[rand.Next(keyCode.Length)];
                if (validateCode.Contains("0") && a == "O") continue;
                if (validateCode.Contains("O") && a == "0") continue;
                validateCode += a;
                if (validateCode.Length == count) canLoop = false;
            }
            #endregion
            Console.WriteLine(validateCode);
        }
    }
}
