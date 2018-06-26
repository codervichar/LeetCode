using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (root.val > q.val && root.val > p.val)
                return LowestCommonAncestor(root.left, p, q);
            else if (root.val < q.val && root.val < p.val)
                return LowestCommonAncestor(root.right, p, q);
            else 
                return root;
        }
    }
}
