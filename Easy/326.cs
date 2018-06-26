using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            if (n == 1)
                return true;
            else if (n < 1)
                return false;
            return n % 3 == 0 && IsPowerOfThree(n / 3);
        }
    }
}
