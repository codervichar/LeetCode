using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> pathList = new List<string>();

            if (root == null)
                return pathList;

            string rootVal = root.val.ToString();
            IList<string> left = BinaryTreePaths(root.left);
            IList<string> right = BinaryTreePaths(root.right);

            if (left.Count > 0)
            {
                foreach (string temp in left)
                {
                    pathList.Add(rootVal + "->" + temp);
                }
            }

            if (right.Count > 0)
            {
                foreach (string temp in right)
                {
                    pathList.Add(rootVal + "->" + temp);
                }
            }

            if (left.Count == 0 && right.Count == 0)
                pathList.Add(rootVal);

            return pathList;
        }
    }
}
