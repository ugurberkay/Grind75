using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind75.Week1
{
    internal class TwoSumProblem
    {
        static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        Console.WriteLine($"Indices are : {result[0]} and {result[1]}");
                        return result;
                    }
                }
            }
            return result;
        }

        static void TwoSumHash(int[] nums, int target)
        {
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                hashtable.Add(nums[i], i);

            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (hashtable.ContainsKey(target - nums[j]) && j != (int)hashtable[target - nums[j]])
                {

                    Console.WriteLine("" + j + "" + hashtable[target - nums[j]]);
                    return;
                }
            }
        }

        static void TwoSumHashOne(int[] nums, int target)
        {
            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                int find = target - nums[i];
                if (hashtable.ContainsKey(find))
                {
                    Console.WriteLine("" + i + "" + hashtable[find]);
                    return;
                }
                hashtable.Add(nums[i], i);
            }
        }
    }
}
