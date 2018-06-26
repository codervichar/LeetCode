using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hard
{
    partial class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            int max = 0, sum = 0;
            foreach (int i in nums)
            {
                max = max < i ? i : max;
                if(i > 0)
                {
                    sum += i;
                }
            }

            int total = (max * (max + 1)) / 2;
            if (sum == total)
                return max + 1;
            else
                return total - sum;
        }
    }
}
