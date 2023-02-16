using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind75.Week1
{
    internal class BestTimeStock
    {
        public static int MaxProfit(int[] prices)
        {
            //Find min of array
            //After min array index Find Max
            //Brute Force Approach
            int profit = 0;
            for (int i = 0; i < prices.Length-1; i++)
            {
                for (int j = i+1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i]>profit)
                    {
                        profit = prices[j] - prices[i];
                    }
                }
            }
            return profit;
        }

        //We are finding min and check for every item in just one for
        //O(n) O(1)
        public static int MaxProfitPerf(int[] prices)
        {
            int min=prices[0];
            int profit=0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i]<min)
                {
                    min= prices[i];
                }
                else if (prices[i]-min>profit)
                {
                    profit = prices[i] - min;
                }
            }
            return profit;
            
        }
    }
}
