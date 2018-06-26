using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int lastIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    if (lastIndex == -1)
                        lastIndex = i;
                    continue;
                }

                if (lastIndex != -1)
                {
                    nums[lastIndex] = nums[i];
                    lastIndex++;
                }
            }
            lastIndex = lastIndex == -1 ? nums.Length : lastIndex;
            return lastIndex;
        }
    }
}