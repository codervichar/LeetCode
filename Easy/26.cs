using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int len = nums.Length;
            if (nums == null || nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return 1;

            int lastIndex = 0;
            for(int i=1; i < len; i++)
            {
                if (nums[i] == nums[lastIndex])
                {
                    nums[i] = Int32.MinValue;
                }
                else
                    lastIndex = i;
            }

            lastIndex = Int32.MinValue;
            for(int i=1; i < len;i++)
            {
                if(nums[i] == Int32.MinValue)
                {
                    if(lastIndex == Int32.MinValue)
                        lastIndex = i;
                    continue;
                }
                if(lastIndex > Int32.MinValue)
                {
                    nums[lastIndex] = nums[i];
                    lastIndex++;
                }
            }

            lastIndex = lastIndex == Int32.MinValue ? nums.Length : lastIndex;
            return lastIndex;
        }
    }
}
