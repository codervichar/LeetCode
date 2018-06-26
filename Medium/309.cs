using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MaxProfitV3(int[] prices)
        {
            if (prices == null || prices.Length < 2)
                return 0;

            int[] dp = new int[prices.Length];
            
            int max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                int val = Math.Max(prices[i] - prices[i - 1], 0);
                dp[i] = val;
                if (val > dp[i - 1] && dp[i - 1] > 0)
                {
                    max = max + dp[i] - dp[i - 1];
                }
                if (dp[i - 1] == 0)
                {
                    max += val;
                }
                else
                    dp[i] = 0;
            }

            return max;
        }
    }
}
