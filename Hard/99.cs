using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public void RecoverTree(TreeNode root)
        {
            TreeNode node1 = null, node2 = null;

            FixTree(root, Int32.MinValue, Int32.MaxValue, ref node1, ref node2);

            if (node1 != null && node2 != null)
            {
                int temp = node1.val;
                node1.val = node2.val;
                node2.val = temp;
            }
        }

        public void FixTree(TreeNode root, int min, int max, ref TreeNode node1, ref TreeNode node2)
        {
            if (root == null)
                return;

            if (root.left != null && (root.left.val > root.val || root.left.val > max))
            {
                node1 = root;
                node2 = (node2 == null ? root : node2);
             }

            if (root.right != null && (root.right.val < root.val || root.right.val < min))
            {
                node2 = root.right;
                node1 = (node1 == null ? root : node1);
            }

            if( root.left != null )
                FixTree(root.left, min, root.left.val, ref node1, ref node2);
            if (root.right != null)
                FixTree(root.right, root.right.val, max, ref node1, ref node2);
        }
    }
}
