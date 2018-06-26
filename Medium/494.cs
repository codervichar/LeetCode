using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int FindTargetSumWays(int[] nums, int S)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            return FindTargetSumWays(nums, S, 0, nums.Length - 1);
        }

        public int FindTargetSumWays(int[] nums, int S, int lo, int hi)
        {
            if (lo > hi)
                return 0;

            if(lo == hi)
            {
                if (S == nums[lo] && nums[lo] == 0)
                    return 2;
                if (S == -nums[lo] || S == nums[lo])
                    return 1;
                return 0;
            }

            return FindTargetSumWays(nums, S -nums[lo], lo + 1, hi) +
                FindTargetSumWays(nums, S + nums[lo], lo + 1, hi);
                //+ FindTargetSumWays(nums, S, lo + 1, hi);
        }
    }
}
