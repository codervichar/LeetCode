using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int ThirdMax(int[] nums)
        {
            int k = 2;
            if (nums.Length < 3)
                k = nums.Length - 1;

            int index = -1, lo = 0, hi = nums.Length - 1;
            while (true)
            {
                index = Partition(nums, lo, hi);
                if (index == k)
                    return nums[index];
                else if (index < k)
                {
                    lo = index + 1;
                }
                else
                {
                    hi = index - 1;
                }
            }
        }
    }
}
