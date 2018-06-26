using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int FindMaxConsecutiveOnesV2(int[] nums)
        {
            int maxCount = 0, count1 = 0, count2 = 0;
            bool zeroFlipped = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if(zeroFlipped)
                    {
                        maxCount = Math.Max(maxCount, count2);
                        count2 = count1;
                    }
                    else
                    {
                        count2++;
                        zeroFlipped = true;
                    }
                    count1 = 0;
                }
                else if (nums[i] == 1)
                {
                    count1++;
                    count2++;
                }
            }
            return Math.Max(count, maxCount);
        }
    }
}
