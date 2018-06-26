using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            int i = 0, j = 0;

            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int len = nums.Length;

            while (true)
            {
                i = (i + 1) % len;
                j = (j + 2) % len;

                if (nums[i] == nums[j])
                    break;
            }

            return nums[i];
        }
    }
}
