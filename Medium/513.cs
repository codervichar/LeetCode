using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int FindBottomLeftValue(TreeNode root)
        {

            var tuple = FindBottomLeftValue(root, 0);
            return tuple.Item1;
        }

        private Tuple<int, int> FindBottomLeftValue(TreeNode root, int level)
        {
            Tuple<int, int> tuple1 = null, tuple2 = null;
            if(root.left != null)
                tuple1 = FindBottomLeftValue(root.left, level+1);

            if (root.right != null)
                tuple2 = FindBottomLeftValue(root.right, level+1);

            if (tuple2 == null && tuple1 == null)
                return new Tuple<int, int>(root.val, level);

            if (tuple2 == null && tuple1 != null)
                return new Tuple<int, int>(tuple1.Item1, tuple1.Item2);

            if (tuple1 == null && tuple2 != null)
                return new Tuple<int, int>(tuple2.Item1, tuple2.Item2);

            if (tuple1.Item2 >= tuple2.Item2)
                return new Tuple<int, int>(tuple1.Item1, tuple1.Item2);
            else
                return new Tuple<int, int>(tuple2.Item1, tuple2.Item2);
        }
    }
}
