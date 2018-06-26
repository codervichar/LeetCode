//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    partial class Solution
//    {
//        public int FindTilt(TreeNode root)
//        {
//            if (root == null)
//                return 0;

//            if (root.left == null && root.right == null)
//                return 0;

//            int left = root.left != null ? root.left.val : 0;
//            int right = root.right != null ? root.right.val : 0;

//            int tilt = Math.Abs(left - right);
//            return tilt + FindTilt(root.left) + FindTilt(root.right);
//        }
//    }
//}
