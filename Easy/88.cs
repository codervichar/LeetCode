using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int len1 = nums1.Length, len2 = nums2.Length;
            int i = 0, j = 0;

            while(i < len1 && j < len2)
            {
                if( nums1[i] > nums2[j])
                {
                    int temp = nums2[i];
                    nums2[i] = nums1[i];
                    nums1[i] = temp;
                    j++;
                }
                i++;
            }
            j = 0;
            while(j<len2)
            {
                nums1[i] = nums2[j];
                i++;
                j++;
            }
        }
    }
}
