using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];

            int maxLen = 0, len = 1;
            for(int i=0;i<nums.Length-1;i++)
            {
                if(nums[i]<nums[i+1])
                {
                    len++;
                }
                else
                {
                    maxLen = Math.Max(maxLen, len);
                    len = 1;
                }
            }

            return Math.Max(maxLen, len);
        }
    }
}
