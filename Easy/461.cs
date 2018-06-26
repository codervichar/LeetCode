using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int count = 0, i = 0;
            while (i < 32)
            {
                if (((x & 1) ^ (y & 1)) == 1)
                    count++;
                x = x >> 1;
                y = y >> 1;
                i++;
            }
            return count;
        }
    }
}
