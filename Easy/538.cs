using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public TreeNode ConvertBST(TreeNode root)
        {
            int val = 0;
            ConvertToGreater(root, ref val);
            return root;
        }

        private void ConvertToGreater(TreeNode root,ref int val)
        {
            if (root == null)
                return;

            ConvertToGreater(root.right, ref val);

            root.val += val;
            val = root.val;

            ConvertToGreater(root.left, ref val);
        }
    }
}
