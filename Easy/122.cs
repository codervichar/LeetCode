using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MaxProfitV2(int[] prices)
        {
            if (prices == null || prices.Length < 2)
                return 0;

            int max = 0;
            for(int i=1;i<prices.Length;i++)
            {
                max = Math.Max(prices[i] - prices[i - 1] + max, max);
            }

            return max;
        }

    }
}
