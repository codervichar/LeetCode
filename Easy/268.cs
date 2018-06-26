using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MissingNumber(int[] nums)
        {
            if(nums == null || nums.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            foreach(int temp in nums)
            {
                sum += temp;
            }

            int len = nums.Length;
            int computedSum = (len * (len + 1)) / 2;

            return computedSum - sum;
        }
    }
}
