using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_BBQ
{
    public static class Conv
    {
        /// <summary>
        /// from string to int
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int ToInt(string number)
        {
            int result;
            int.TryParse(number, out result);
            return result;
        }
    }
}
