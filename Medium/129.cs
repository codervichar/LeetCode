using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int SumNumbers(TreeNode root)
        {
            int val1 = SumNumbers(root, 0);

            return val1;
        }

        public int SumNumbers(TreeNode root, int num)
        {
            if (root == null)
                return num;

            int val1 = 0, val2 = 0, val3 = 0;

            if (root.left != null)
                val1 = SumNumbers(root.left, (num * 10) + root.val);
            if (root.right != null)
                val2 = SumNumbers(root.right, (num * 10) + root.val);

            if( root.left == null && root.right == null)
                val3 = (num * 10) + root.val;

            return val1 + val2 + val3;
        }
    }
}
