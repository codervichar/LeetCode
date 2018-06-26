using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            if (nums == null || nums.Length < k)
                return -1;

            int index = -1, lo = 0, hi = nums.Length - 1;
            k--;
            while(true)
            {
                index = Partition(nums, lo, hi);
                if (index == k)
                    return nums[index];
                else if(index < k)
                {
                    lo = index + 1;
                }
                else
                {
                    hi = index - 1;
                }
            }
        }

        public int Partition(int[] nums,int lo, int hi)
        {
            int i = lo - 1, j = lo;
            int pivot = nums[hi];

            for(j=lo;j<hi;j++)
            {
                if(nums[j] <= pivot)
                {
                    i++;
                    if( i!=j )
                    {
                        int temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                }
            }

            nums[hi] = nums[i+1];
            nums[i+1] = pivot;

            return i+1;
        }
    }
}
