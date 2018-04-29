using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Examples_Regex
{
    static class RegexOperation
    {
        public static void RegexMatches(string s, string p)
        {
            var matches = Regex.Matches(s, p);
            foreach (Match item in matches)
            {
                Console.WriteLine($"{item.Index} {item.Value} {item.Length} {item.Success} { item.Groups.Count}");
            }
        }



    }
}
