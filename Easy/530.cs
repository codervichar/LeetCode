//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    partial class Solution
//    {
//        public int GetMinimumDifference(TreeNode root)
//        {
//            int minValue = Int32.MaxValue, maxValue = -1;
//            InOrderTraversal(root, ref minValue, -1);

//            return minValue;
//        }

//        public void InOrderTraversal(TreeNode root, ref int min, int value)
//        {
//            int val = 0;
            
//            if( root != null )
//            {
//                InOrderTraversal(root.left, ref min, root.val);

//                val = Math.Abs(value - root.val);
//                min = min > val ? val : min;

//                InOrderTraversal(root.right, ref min, root.val);
//            }
            
//            if ( root.right == null)
//            {
//                childValue = root.val;
//            }
//            else if ( root.right != null )
//            {
//                InOrderTraversal(root.right, ref min, ref childValue);
//                val = Math.Abs(childValue - root.val);
//                min = min > val ? val : min;
//                childValue = root.val;
//            }
//        }
//    }
//}
