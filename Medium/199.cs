using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public IList<int> RightSideView(TreeNode root)
        {
            Queue<TreeNode> p = new Queue<TreeNode>(), q = new Queue<TreeNode>();
            List<int> numList = new List<int>();

            p.Enqueue(root);
            while (p.Count > 0)
            {
                while (p.Count > 1)
                {
                    TreeNode t = p.Dequeue();
                    AddToQ(q, t);
                }

                TreeNode temp = p.Dequeue();
                AddToQ(q, temp);

                numList.Add(temp.val);

                p = q;
                q = new Queue<TreeNode>();
            }

            return numList;
        }

        private static void AddToQ(Queue<TreeNode> q, TreeNode temp)
        {
            if (temp.left != null)
                q.Enqueue(temp.left);
            if (temp.right != null)
                q.Enqueue(temp.right);
        }
    }
}
