using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int PivotIndex(int[] nums)
        {
            int sum = 0, maxSum = 0;
            for(int i=0;i<nums.Length;i++)
            {
                sum += nums[i];
            }
            maxSum = sum;
            sum = 0;
            for(int i=0;i<nums.Length;i++)
            {
                maxSum -= nums[i];
                
                if ( sum == maxSum )
                {
                    return i;
                }

                sum += nums[i];
            }

            return -1;
        }
    }
}
