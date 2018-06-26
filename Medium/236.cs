using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public TreeNode LowestCommonAncestorV2(TreeNode root, TreeNode p, TreeNode q)
        {
            return LCA(root, ref p, ref q);
        }

        public TreeNode LCA(TreeNode root, ref TreeNode p, ref TreeNode q)
        {
            TreeNode temp = root;

            if (root == null)
                return null;
            
            temp = LCA(root.left, ref p, ref q);

            if (p != null || q != null)
            {
                temp = LCA(root.right, ref p, ref q);
            }

            if ( p != null && root.val == p.val)
            {
                p = null;
            }
            if( q!= null && root.val == q.val)
            {
                q = null;
            }

            if (p == null && q == null && temp == null)
                temp = root;

            if (p == null && q == null)
                return temp;
            else
                return null;
        }
    }
}
