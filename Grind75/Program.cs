using Grind75.Utility;
using Grind75.Week1;

namespace Grind75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {-1,0,3,5,9,12 };

            Console.WriteLine(BinarySearch.Search(nums, 9));
           Console.WriteLine(BinarySearch.Search(nums, 2));
            Console.WriteLine(BinarySearch.Search(nums, 0));
            Console.WriteLine(BinarySearch.Search(nums, -1));
        }
    }
}