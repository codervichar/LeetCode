using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int[] TwoSum2(int[] numbers, int target)
        {
            if (numbers == null)
                return null;
            if (numbers.Length == 1 && numbers[0] == target)
            {
                return new int[] { target };
            }
            else if (numbers.Length == 1)
            {
                return null;
            }

            for(int i=0;i < numbers.Length; i++)
            {
                int val = target - numbers[i];
                int index = BinarySearchTwoSum(numbers, i + 1, numbers.Length - 1, val);
                if (index != -1)
                    return new int[] { i+1, index+1 };
            }

            return null;
        }
        
        private int BinarySearchTwoSum(int[] numbers, int lo, int hi, int val)
        {
            if (lo > hi)
                return -1;

            int mid = (lo + hi) / 2;
            if (numbers[mid] < val)
            {
                return BinarySearch(numbers, lo + 1, hi, val);
            }
            else if (numbers[mid] > val)
            {
                return BinarySearch(numbers, lo, hi-1, val);
            }
            else
                return mid;
        }
    }
}
