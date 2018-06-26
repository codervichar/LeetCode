using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return false;

            HashSet<int> uniqueSet = new HashSet<int>();
            for(int i = 0;i < nums.Length;i++)
            {
                if (uniqueSet.Contains(nums[i]))
                    return true;
                else
                    uniqueSet.Add(nums[i]);
            }
            return false;
        }
    }
}
