using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null)
                return null;
            if( nums.Length == 1 && nums[0] == target )
            {
                return new int[] { target };
            }
            else if( nums.Length == 1 )
            {
                return null;
            }

            Dictionary<int, HashSet<int>> numList = new Dictionary<int, HashSet<int>>();
            
            for(int i=0; i < nums.Length; i++)
            {
                if(numList.ContainsKey(nums[i]))
                {
                    numList[nums[i]].Add(i);
                }
                else
                {
                    numList.Add(nums[i], new HashSet<int> { i });
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                numList[nums[i]].Remove(i);
                int val = target - nums[i];
                if (numList.ContainsKey(val) && numList[val].Count > 0)
                    return new int[] { i, numList[val].First()};
            }
            return null;
        }
    }
}
