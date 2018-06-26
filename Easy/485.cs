using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxCount = 0, count = 0;
            for(int i=0; i<nums.Length;i++)
            {
                if(nums[i] == 0 )
                {
                    maxCount = Math.Max(count, maxCount);
                    count = 0;
                }
                else if(nums[i] == 1)
                {
                    count++;
                }
            }
            return Math.Max(count, maxCount);
        }
    }
}
