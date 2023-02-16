using Grind75.Utility;
using Grind75.Week1;

namespace Grind75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "anagram";
            string t1 = "nagaram";
            string s2 = "rat";
            string t2 = "car";

            Console.WriteLine(ValidAnagram.IsAnagram(s1,t1));
            Console.WriteLine(ValidAnagram.IsAnagram(s2, t2));
        }
    }
}