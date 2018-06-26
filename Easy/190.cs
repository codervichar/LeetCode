using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public uint reverseBits(uint n)
        {
            uint val = 0;
            int j = 32;
            while(j>0)
            {
                val = val << 1;
                val = val | (n & 1);
                n = n >> 1;
                j--;
            }
            return val;
        }
    }
}
