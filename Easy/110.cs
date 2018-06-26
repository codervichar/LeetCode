using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            int height = Height(root);

            return height == -1 ? false : true;
        }

        public int Height(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            

            int leftHeight = Height(root.left);
            int rightHeight = Height(root.right);

            if (leftHeight == -1)
                return -1;
            else if (rightHeight == -1)
                return -1;
            else if (Math.Abs(leftHeight - rightHeight) > 1)
                return -1;

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
