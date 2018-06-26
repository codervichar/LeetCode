using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public IList<int> LargestValues(TreeNode root)
        {
            Queue<TreeNode> p = new Queue<TreeNode>(), q = new Queue<TreeNode>();
            List<int> numList = new List<int>();

            p.Enqueue(root);
            while (p.Count>0)
            {
                int max = Int32.MinValue;
                while (p.Count > 0)
                {
                    TreeNode t = p.Dequeue();
                    AddToQ(q, t);
                    max = max < t.val ? t.val : max;
                }
                numList.Add(max);

                p = q;
                q = new Queue<TreeNode>();
            }

            return numList;
        }

        private static void AddToQueue(Queue<TreeNode> q, TreeNode temp)
        {
            if (temp.left != null)
                q.Enqueue(temp.left);
            if (temp.right != null)
                q.Enqueue(temp.right);
        }
    }
}
