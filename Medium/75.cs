using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public void SortColors(int[] nums)
        {
            if (nums == null || nums.Length == 1)
                return;
            if( nums.Length == 2)
            {
                if(nums[0] > nums[1])
                {
                    int temp = nums[0];
                    nums[0] = nums[1];
                    nums[1] = temp;
                }
                return;
            }

            int i = 0, j = 0, n = nums.Length-1;
            int midVal = 1;

            while(j<=n)
            {
                if(nums[j] < midVal)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;

                    i++;
                    j++;
                }
                else if(nums[j] > midVal)
                {
                    int temp = nums[n];
                    nums[n] = nums[j];
                    nums[j] = temp;

                    n = n - 1;
                }
                else
                {
                    j++;
                }
            }
        }
    }
}
