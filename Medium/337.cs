using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        class Values
        {
            public int childVal, rootVal;
        }

        public int RobV2(TreeNode root)
        {
            var val = Robb(root);

            return val.rootVal > val.childVal ? val.rootVal : val.childVal; ;
        }

        private Values Robb(TreeNode root)
        {
            if (root == null)
                return new Values();


            var left = Robb(root.left);
            var right = Robb(root.right);

            var includeRoot = root.val + left.childVal + right.childVal;
            var childOnly = Math.Max(left.rootVal, left.childVal) + Math.Max(right.rootVal, right.childVal);

            return new Values() { childVal = childOnly, rootVal = includeRoot };
        }
    }
}
