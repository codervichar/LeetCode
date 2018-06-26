using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int LongestConsecutive(TreeNode root)
        {
            if (root.left == null && root.right == null)
                return 1;

            return 0;
        }
    }
}
