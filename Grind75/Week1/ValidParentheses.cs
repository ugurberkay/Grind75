using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind75.Week1
{
    internal class ValidParentheses
    {

        public bool IsValid(string s)
        {
            //Stack Solution
            //O(n) Time Complexity
            //O(n) Space Complexity
            Stack<char> stack = new Stack<char>();
            for (int i=0;i<s.Length;i++)
            {
                if (s[i]=='(' || s[i] == '{'|| s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else 
                {
                    if (stack.Count <= 0)
                        return false;
                    if(stack.Peek()=='(' && s[i] == ')')
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '[' && s[i] == ']')
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '{' && s[i] == '}')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        public bool IsValidSpace(string s)
        {
            //O(n) Time Complexity
            //O(1) Space Complexity ----------->Just changing string
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i]==')' || s[i] == ']' || s[i] == '}'))
                {
                    if (i != 0 && s[i] == ')' && s[i-1]=='('  )
                    {
                        s=s.Remove(i-1,2);
                        i -= 2;
                    }
                    else if (i != 0 && s[i] == ']' && s[i - 1] == '[' )
                    {
                        s=s.Remove(i - 1, 2);
                        i -= 2;
                    }
                    else if (s[i] == '}' && s[i - 1] == '{' && i != 0)
                    {
                        s=s.Remove(i - 1, 2);
                        i -= 2;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
