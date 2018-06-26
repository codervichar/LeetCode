using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length-1);
        }

        public TreeNode SortedArrayToBST(int[] nums, int lo, int hi)
        {
            if (lo > hi)
                return null;
            int mid = (lo + hi) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = SortedArrayToBST(nums, lo, mid - 1);
            root.right = SortedArrayToBST(nums, mid + 1, hi);

            return root;
        }
    }
}
