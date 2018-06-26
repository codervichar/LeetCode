using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class NumArray
    {
        int[] numArray;
        public NumArray(int[] nums)
        {
            numArray = nums;
            for (int i=1;i<nums.Length;i++)
            {
                nums[i] += nums[i - 1];
            }
        }

        public int SumRange(int i, int j)
        {
            if( i== 0)
            {
                return numArray[j];
            }
            else
            {
                return numArray[j] - numArray[i - 1];
            }
        }
    }
}
