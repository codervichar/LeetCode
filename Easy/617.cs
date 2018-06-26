using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            TreeNode root = t1;

            if (t1 == null && t2 == null)
                return null;
            else if (t1 != null && t2 != null)
                t1.val += t2.val;
            else if (t1 == null)
            {
                root = t2;
                t2 = null;
            }

            root.left = MergeTrees(root.left, t2 == null ? null : t2.left);
            root.right = MergeTrees(root.right, t2 == null ? null : t2.right);

            return root;
        }
    }
}
