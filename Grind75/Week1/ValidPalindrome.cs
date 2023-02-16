using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Grind75.Week1
{
    internal class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            if (s==" ")
            {
                return true;
            }
            s = s.ToLower();
            s = s.Replace(" ", "");
            s = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty);
            int j = s.Length - 1;
            for (int i=0;i<s.Length;i++)
            {
                if (i >= j)
                {
                    return true;
                }
                else
                {
                    if (s[i] != s[j])
                    {
                        return false;
                    }
                }
                j--;
            }
            return true;
        }
    }
}
