using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return  ConstructMaximumBinaryTree(nums, 0, nums.Length - 1);
        }

        private TreeNode ConstructMaximumBinaryTree(int[] nums, int lo, int hi)
        {
            if (lo > hi)
                return null;

            int maxIndex = lo;
            for (int i = lo + 1; i <= hi; i++)
            {
                if (nums[i] > nums[maxIndex])
                {
                    maxIndex = i;
                }
            }

            TreeNode root = new LeetCode.TreeNode(nums[maxIndex]);
            root.left = ConstructMaximumBinaryTree(nums, lo, maxIndex - 1);
            root.right = ConstructMaximumBinaryTree(nums, maxIndex+1, hi);

            return root;
        }
    }
}

