using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MaxProfit(int k, int[] prices)
        {
            if (prices == null || prices.Length < 2 || k==0  )
                return 0;

            k = k * 2;
            int[,] dp = new int[prices.Length + 1, k + 1];

            dp[0, 0] = 0;
            int max = Int32.MinValue;

            for (int i = 1; i <= prices.Length; i++)
            {
                if (i <= k)
                    if (i % 2 == 1)
                    {
                        dp[i, i] = dp[i - 1, i - 1] - prices[i - 1];
                    }
                    else
                    {
                        dp[i, i] = dp[i - 1, i - 1] + prices[i - 1];
                    }
                dp[i, 1] = max = Math.Max(max, -prices[i - 1]);
            }
            max = Int32.MinValue;
            for (int j = 2; j <= k; j++)
            {
                for (int i = j + 1; i <= prices.Length; i++)
                {
                    if (j % 2 == 0)
                    {
                        dp[i, j] = Math.Max(prices[i - 1] + dp[i - 1, j - 1], dp[i - 1, j]);
                        max = Math.Max(max, dp[prices.Length, j]);
                    }
                    else
                    {
                        dp[i, j] = Math.Max(-prices[i - 1] + dp[i - 1, j - 1], dp[i - 1, j]);
                    }
                }

            }
            max = Math.Max(max, 0);
            return max;
        }
    }
}
