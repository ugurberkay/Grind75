using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind75.Week1
{
    internal class BinarySearch
    {


        public static int Search(int[] nums,int target)
        {
            int i = 0;
            int j=nums.Length - 1;


            while (j>=i)
            {
                int m = (j + i) / 2;
                if (nums[m]==target)
                {
                    return m;
                }
                else if (nums[m]<target)
                {
                    i = m + 1;
                }
                else
                {
                    j = m - 1;
                }
            }
            return -1;
        }
    }
}
