using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool IsPowerOfFour(int num)
        {
            if ((num & (num - 1)) != 0)
                return false;
            int count = 0;
            while(num>1)
            {
                num = num >> 1;
                count++;
            }
            if (count % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
