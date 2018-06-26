using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 0;

            return Sum(root);
        }

        private int Sum(TreeNode root)
        {
            if (root.left == null && root.right == null)
                return root.val;

            int sum1 = 0, sum2 = 0;
            if (root.left != null)
            {
                sum1 = Sum(root.left);
            }
            if (root.right != null && !IsLeafNode(root.right))
                sum2 = Sum(root.right);

            return sum1 + sum2;
        }

        private bool IsLeafNode(TreeNode root)
        {
            if (root.left == null && root.right == null)
                return true;
            return false;
        }
    }
}
