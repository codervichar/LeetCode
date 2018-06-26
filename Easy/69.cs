using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MySqrt(int x)
        {
            int low = 1, high = x, num = x;
            while (low <= high)
            {
                long mid = (long)(low + high) / 2;
                if (mid * mid == num)
                    return (int)mid;
                else if (mid * mid < num)
                {
                    low = (int)mid + 1;
                }
                else
                {
                    high = (int)mid - 1;
                }
            }
            return high;
        }
    }
}
