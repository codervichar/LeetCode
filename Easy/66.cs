using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    partial class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int len = digits.Length;
            List<int> retList = new List<int>();

            int carryover = 1;
            for(int i=len-1; i>=0; i--)
            {
                int val = digits[i] + carryover;
                carryover = val / 10;

                retList.Add(val % 10);
            }
            if (carryover == 1)
                retList.Add(1);

            retList.Reverse();
            return retList.ToArray();
        }
    }
}
