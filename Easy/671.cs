//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    partial class Solution
//    {
//        public int FindSecondMinimumValue(TreeNode root)
//        {
//            if (root == null)
//                return -1;

//            if (root.left == null && root.right == null)
//            {
//                return root.val;
//            }

//            int max1 = root.val, max2 = 0;
//            if (root.val == root.left.val)
//            {
//                max1 = FindSecondMinimumValue(root.left);
//                max2 = root.right.val;
//            } 

//            if ( root.val == root.right.val)
//                max2 = FindSecondMinimumValue(root.right);


//            return FindVal(root.val, leftVal, rightVal);
//        }

//        public int FindVal(int val, int val1, int val2)
//        {
//            HashSet<int> set = new HashSet<int>();
//            set.Add(val);
//            set.Add(val1);
//            set.Add(val2);
//            set.OrderBy(s => s);
//        }

//    }
//}
