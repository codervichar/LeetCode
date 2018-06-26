using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int hi = nums.Length;
            int lo = 0, mid = hi / 2, index = -1;
            
            while (true)
            {
                index = partition(nums, lo, hi-1);
                if (index < mid)
                {
                    lo = index + 1;
                }
                else if (index > mid)
                {
                    hi = index;
                }
                else
                    return nums[index];
            }
        }

        private int partition(int[] nums, int lo, int high)
        {
            int i = lo, j = high;

            Random random = new Random();

            int pivotIndex = random.Next(lo, high);
            int pivot = nums[pivotIndex];
            while (i < j)
            { 
                while (i <= high && nums[i] < pivot)
                    i++;
                while (j >= 0 && nums[j] >= pivot)
                    j--;

                if( i < j)
                {
                    Swap(nums, i, j);
                }
            }
            if (i > high)
                return pivot;

            if (i <= high && i < pivotIndex && nums[pivotIndex] < nums[i] )
                Swap(nums, pivotIndex, i);

            if (i <= high && i > pivotIndex && nums[pivotIndex] > nums[i])
                Swap(nums, pivotIndex, i);

            return i;
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[j];
            nums[j] = nums[i];
            nums[i] = temp;
        }
    }
}
