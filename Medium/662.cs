using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            Queue<TreeNode> p = new Queue<TreeNode>(), q = new Queue<TreeNode>();

            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return 0;

            int start = 1, end = 1;

            if (root.left != null)
            {
                p.Enqueue(root.left);
                start = 0;
            }
            else
                start = 1;

            if (root.right != null)
            {
                p.Enqueue(root.right);
                end = 2;
            }

            int level = 0, maxWidth = 0;
            
            while (p.Count >0)
            {
                level++;
                TreeNode temp = p.Dequeue();

                if (temp.left != null)
                {
                    q.Enqueue(temp.left);
                    start = Math.Max(start - 1, 0);
                }
                else if (temp.right != null)
                {
                    q.Enqueue(temp.right);
                    start = start + 1;
                }

                if (p.Count > 0)
                {
                    temp = p.Dequeue();

                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                        end = end + 2;
                    }
                    else if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                        end = end + 1;
                    }
                }

                maxWidth = maxWidth > (end - start) ? maxWidth : (end - start);
                
                p = q;
                q = new Queue<TreeNode>();
            }
            return maxWidth;
        }
    }
}
