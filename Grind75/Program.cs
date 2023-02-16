using Grind75.Week1;

namespace Grind75
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "A man, a plan, a canal: Panama";
            string s2 = "race a car";
            string s3 = " ";

            Console.WriteLine(ValidPalindrome.IsPalindrome(s));
            Console.WriteLine(ValidPalindrome.IsPalindrome(s2));
            Console.WriteLine(ValidPalindrome.IsPalindrome(s3));
        }
    }
}