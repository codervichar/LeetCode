using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int len = nums.Length, sum = 0, minLen = Int32.MaxValue;
            int j = 0, i = 0;

            for (i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                while (sum - nums[j] >= s)
                {
                    sum -= nums[j];
                    j++;
                }

                if (sum >= s)
                {
                    minLen = Math.Min(i - j, minLen);
                }
            }

            if (minLen == Int32.MaxValue)
                minLen = 0;
            else
                minLen++;
            return minLen;
        }
    }
}
