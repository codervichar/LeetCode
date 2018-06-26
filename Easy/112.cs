using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;

            if (IsLeafNode(root) && root.val == sum)
                return true;
            else if (IsLeafNode(root))
                return false;

            int val = sum - root.val;
            return HasPathSum(root.left, val) || HasPathSum(root.right, val);
        }
    }
}
