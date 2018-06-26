using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    partial class Solution
    {
        public bool IsPerfectSquare(int num)
        {
            int i = 1;
            while(num > 0)
            {
                num -= i;
                i += 2;
            }
            return num == 0;
        }

        public bool IsPerfectSquareV2(int num)
        {
            int low = 1, high = num;
            while(low <= high)
            {
                long mid = (low + high) / 2;
                if (mid * mid == num)
                    return true;
                else  if ( mid * mid < num )
                {
                    low = (int)mid + 1;
                }
                else
                {
                    high = (int)mid-1;
                }
            }
            return false;
        }
    }
}
