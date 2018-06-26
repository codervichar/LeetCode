using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            if (bits == null || bits.Length == 0)
                return false;
            
            bool isSingle = true;
            for(int i=0;i<bits.Length;)
            {
                if (bits[i] == 0)
                {
                    i++;
                    isSingle = true;
                }
                else if (bits[i] == 1)
                {
                    i += 2;
                    isSingle = false;
                }
            }
            return isSingle;
        }
    }
}
