using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int LongestUnivaluePath(TreeNode root)
        {
            int maxValue = 0, childValue = 0;
            LongestUnivaluePath(root, ref maxValue, ref childValue);
            return maxValue > childValue ? maxValue : childValue;
        }

        public void LongestUnivaluePath(TreeNode root, ref int maxValue, ref int childValue)
        {
            if( IsLeafNode(root))
            {
                maxValue = 0;
                childValue =0;
                return;
            }

            int max1=0, child1 = 0, max2=0, child2 = 0;
            if (root.left != null)
            {
                LongestUnivaluePath(root.left, ref max1, ref child1);
                if (root.val == root.left.val)
                    child1 = child1 + 1;
                else
                    child1 = 0;

                max1 = max1 > child1 ? max1 : child1;
            }

            if (root.right != null)
            {
                LongestUnivaluePath(root.right, ref max2, ref child2);
                if (root.val == root.right.val)
                    child2 = child2 +1;
                else
                    child2 = 0;

                max2 = max2 > child2 ? max2 : child2;
            }

            maxValue = max1 > max2 ? max1 : max2;
            maxValue = maxValue > (child1+child2) ? maxValue : (child1 + child2);
            childValue = child1 > child2 ? child1 : child2;
        }
    }
}
