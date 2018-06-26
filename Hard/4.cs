//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    partial class Solution
//    {
//        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
//        {
//            if (nums1 == null && nums2 == null)
//                return -1;
//            else if (nums1 == null && nums2 != null)
//                return (nums2.Length == 0 ? -1 : nums2[(nums2.Length - 1) / 2]);
//            else if (nums1 != null && nums2 == null)
//                return (nums1.Length == 0 ? -1 : nums1[(nums1.Length - 1) / 2]);
//            else if (nums1.Length == 0 && nums2.Length == 0)
//                return -1;
//            else
//            {
//                int len1 = nums1.Length, len2 = nums2.Length;
//                int mid = (len1 + len2) / 2, prevValue = -1;
//                for (int i = 0, j = 0, k = 0; i < len1 || j < len2; i++,j++)
//                {

//                    if (j >= len2 || nums1[i] < nums2[j])
//                    {
//                        i++;
//                    }
//                    else
//                    {
//                        j++;
//                    }

//                    if( k==mid)
//                    {
//                        int val1 = j >= len2 ? 0 : nums2[j];
//                        int val2 = i >= len1 ? 0 : nums1[i];
//                        return (val1 + val2) / 2;
//                    }
//                }
//            }
//        }
//    }
//}
