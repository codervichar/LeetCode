using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;

            int[,] dp = new int[prices.Length, 2];

            dp[0, 0] = prices[0];
            for (int j = 1; j < prices.Length; j++)
            {
                dp[j, 0] = Math.Min(prices[j], dp[j - 1, 0]);
            }
            dp[1, 1] = prices[1] - dp[0, 0];
            for (int j=2;j<prices.Length;j++)
            {
                dp[j,1] = Math.Max(prices[j] - dp[j,0], dp[j-1,1]);
            }

            return dp[prices.Length-1, 1];
        }
    }
}
