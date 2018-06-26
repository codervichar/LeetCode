using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool CanPartition(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return false;
            Array.Sort(nums);
            int sum = 0;
            int[,] dp = new int[nums.Length, nums.Length];
            for(int i=0;i<nums.Length;i++)
            {
                sum += nums[i];
                if (Sum(nums, i + 1, nums.Length - 1, sum, dp))
                    return true;
            }
            return false;
        }

        public bool Sum(int[] nums, int lo, int hi, int val, int[,] dp)
        {
            if (lo > hi)
                return false;

            int sum = 0;
            if (dp[lo, hi] != 0)
                sum = dp[lo, hi];
            
            for(int i=lo;i<=hi;i++)
            {
                sum += nums[i];
            }
            dp[lo, hi] = sum;

            if (sum == val)
                return true;
            else
                return false;
        }
    }
}
