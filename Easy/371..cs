using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int GetSum(int a, int b)
        {
            while( a!=0 && b!=0)
            {
                int xor = a ^ b;
                int and = (a & b) << 1;

                a = xor;
                b = and;
            }
            if (b == 0)
                return a;
            else
                return b;
        }
    }
}
