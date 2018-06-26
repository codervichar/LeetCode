using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        int totalSum = 0;

        public int PathSumV3(TreeNode root, int sum)
        {
            totalSum = sum;
            int count = PathSumV3(root, totalSum, true);
            return count;
        }

        public int PathSumV3(TreeNode root, int sum, bool checkTotalSum)
        {
            int count = 0;

            if (root == null)
                return count;

            if (root.val == sum)
                count++;

            count = count + PathSumV3(root.left, sum - root.val, false) + PathSumV3(root.right, sum - root.val, false);
            if( checkTotalSum )
                count += PathSumV3(root.right, totalSum, true) + PathSumV3(root.left, totalSum, true);

            return count;
        }
    }
}
