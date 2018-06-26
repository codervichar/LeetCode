//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    partial class Solution
//    {
//        public int FirstBadVersion(int n)
//        {
//            return FirstBadVersion(n, 1, n);
//        }
        
//        public bool isBadVersion(int n)
//        {
//            return true;
//        }

//        private int FirstBadVersion(int n, int lo, int hi)
//        {
//            if (lo > hi)
//                return -1;

//            int mid = (lo + hi) / 2;
//            if( isBadVersion(mid) )
//            {
//                return FirstBadVersion(n, lo, mid - 1);
//            }
//            else
//            {
//                int val = FirstBadVersion(n, mid + 1, hi);
//                if (val == -1)
//                    return mid;
//                else
//                    return val;
//            }
//        }
//    }
//}
