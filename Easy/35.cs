using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int index = BinarySearch(nums, target, 0, nums.Length-1);
            return index;
        }

        private int BinarySearch(int[] nums, int target, int lo, int hi)
        {
            if (lo > hi)
                return hi;
            int vl = -1;

            int mid = (lo + hi)/ 2;
            if (nums[mid] == target)
                return mid;
            else if(nums[mid] < target)
            {
                vl = BinarySearch(nums, target, mid + 1, hi);
                if (vl == -1)
                    return hi + 1 ;
            }
            else
            {
                vl = BinarySearch(nums, target, lo, hi - 1);
                if (vl == -1)
                    return hi;
            }
            return vl;
        }
    }
}
