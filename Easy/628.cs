using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MaximumProduct(int[] nums)
        {
            if (nums == null || nums.Length < 3)
                return 0;
            return MaximumProduct(nums, 0, 3, 1);
        }

        private int MaximumProduct(int[] nums, int lo, int count, int prod)
        {
            if (count == 0)
                return prod;

            int max = Int32.MinValue;

            for(int i=lo; i< nums.Length && (i+count) <= nums.Length;i++)
            {
                int temp = MaximumProduct(nums, i + 1, count - 1, prod * nums[i]);
                
                max = (max < temp) ? temp : max;
            }

            return max;
        }
    }
}
