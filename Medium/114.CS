using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;

namespace LeetCode.Medium
{
    partial class Solution
    {
        public void Flatten(TreeNode root)
        {
            Stack<TreeNode> stk = new Stack<TreeNode>();
            TreeNode first = root;

            UpdateStack(first, stk);

            while(stk.Count() > 0)
            {
                TreeNode temp = stk.Pop();
                TreeNode left = null;
                if ( temp.right != null)
                {
                    Flatten(temp.right);
                }
                if(  temp.left != null && temp.right != null)
                {
                    left = GetLHSLastNode(temp.left);
                    left.right = temp.right;
                    temp.right = temp.left;
                    temp.left = null;
                }
                else if(temp.left != null)
                {
                    temp.right = temp.left;
                    temp.left = null;
                }
            }
        }

        public TreeNode GetLHSLastNode(TreeNode root)
        {
            while (root.right != null)
                root = root.right;
            return root;
        }

        public void UpdateStack(TreeNode root, Stack<TreeNode> stk)
        {
            while(root != null)
            {
                stk.Push(root);
                root = root.left;
            }
        }
    }
}
