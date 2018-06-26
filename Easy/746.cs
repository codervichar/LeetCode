using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost == null || cost.Length == 1)
                return 0;
            int[] cost2 = new int[cost.Length + 3];

            for (int i = 0; i < cost.Length; i++)
                cost2[i + 2] = cost[i];

            for(int i=2; i<cost2.Length;i++)
            {
                cost2[i] += Math.Min(cost2[i - 1], cost2[i - 2]);
            }

            return cost2[cost2.Length - 1];
        }
    }
}
