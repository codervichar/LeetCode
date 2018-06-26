using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int max = Int32.MinValue;

            int totalSum = 0;
            for(int i=0; i< nums.Length;i++)
            {
                totalSum = (totalSum > 0 ? totalSum : 0) + nums[i];
                max = Math.Max(totalSum, max);
            }

            return max;
        }

        public int MaxSubArray(int[] nums, int len, ref int max)
        {
            if (len == 0)
            {
                return nums[0];
            }

            int val = MaxSubArray(nums, len - 1, ref max);
            int val2 = (val > 0 ? val : 0) + nums[len];

            max = Math.Max(Math.Max(val2, val), max);

            return val2;
        }
    }
}
