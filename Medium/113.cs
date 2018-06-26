using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            List<IList<int>> list = new List<IList<int>>();
            if (root == null)
                return list;

            if(IsLeafNode(root) && root.val == sum)
            {
                list.Add(new List<int>() { root.val });
            }
            else if(IsLeafNode(root))
            {
                return list;
            }

            int val = sum - root.val;
            var left = PathSum(root.left, val);
            foreach (List<int> temp in left)
                temp.Insert(0, root.val);
            var right = PathSum(root.right, val);
            foreach (List<int> temp in right)
                temp.Insert(0, root.val);

            list.AddRange(left);
            list.AddRange(right);

            return list;
        }
    }
}
