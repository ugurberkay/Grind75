using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind75.Week1
{
    internal class ValidAnagram
    {
        //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
        //Need to find characters and their count numbers
        //for that, use hashtable to find frequency of chars(chars to key and count number to value)
        //O(n) Time complexity and O(n) space complexity
        public static bool IsAnagram(string s,string t)
        {
            if (s.Length!=t.Length)
            {
                return false;
            }
            Hashtable ht = new Hashtable();
            foreach (char c in s)
            {
                if (!ht.ContainsKey(c))
                {
                    ht.Add(c, 1);
                }
                else
                {
                    int tempVal = (int)ht[c];
                    tempVal++;
                    ht.Remove(c);
                    ht.Add(c, tempVal);
                }
            }

            foreach (char c in t) 
            {
                if (!ht.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    int tempVal = (int)ht[c];
                    if (tempVal <= 0)
                    {
                        return false;
                    }
                    tempVal--;
                    ht.Remove(c);
                    ht.Add(c, tempVal);
                }
            }

            return true;
        }
    }
}
