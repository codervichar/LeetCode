using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return false;

            Dictionary<int, int> indexHash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if( i-k-1>=0)
                    indexHash.Remove(nums[i - k - 1]);
                if (indexHash.ContainsKey(nums[i]))
                {
                    int j = indexHash[nums[i]];
                    if (Math.Abs(i - j) <= k)
                        return true;
                }
                else
                    indexHash.Add(nums[i], i);
            }
            return false;
        }
    }
}
