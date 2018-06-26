using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            bool[] used = new bool[nums.Length];

            IList<IList<int>> permList = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return permList;

            Array.Sort(nums);
            PermuteUnique(nums, 0, nums.Length - 1, used, permList, new List<int>());

            return permList;
        }

        public void PermuteUnique(int[] nums, int lo, int hi, bool[] used, IList<IList<int>> permList, IList<int> list)
        {
            for (int i = lo; i <= hi; i++)
            {
                if (used[i])
                    continue;
                used[i] = true;

                list.Add(nums[i]);

                if (list.Count == nums.Length)
                {
                    permList.Add(new List<int>(list));
                }
                else
                {
                    if( i > lo && nums[i] == nums[i-1])

                    Permute(nums, lo, hi, used, permList, list);
                }

                list.Remove(nums[i]);
                used[i] = false;
            }
        }
    }
}
