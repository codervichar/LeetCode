using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        bool firstPlayer = true;

        public bool PredictTheWinner(int[] nums)
        {
            int max = Predict(nums, 0, nums.Length - 1);

            dict.Clear();
            firstPlayer = false;
            int max2 = Predict(nums, 1, nums.Length - 1);
            dict.Clear();
            int max3 = Math.Max(max2, Predict(nums, 0, nums.Length - 2));

            if (max >= max3)
                return true;

            return false;
        }

        public int Predict(int[] nums, int lo, int hi)
        {
            if (hi < lo)
                return 0;

            int max = 0;

            if (firstPlayer)
            {
                if (Predict(nums, lo + 1, hi) < Predict(nums, lo, hi - 1))
                    max = nums[hi] + Predict(nums, lo, hi - 2);
                else
                    max = nums[lo] + Predict(nums, lo + 2, hi);
            }
            else
            {
                max = nums[0] + Math.Max(Predict(nums, lo + 2, hi), Predict(nums, lo + 1, hi - 1));
                max = Math.Max(max, nums[hi] + Math.Max(Predict(nums, lo, hi - 2), Predict(nums, lo + 1, hi - 1)));
            }

            return max;
        }
    }
}
