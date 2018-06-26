using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int LengthOfLastWord(string s)
        {
            int len = 0, lastword = 0;
            for(int i=0;i < s.Length;i++)
            {
                if (s[i] == ' ')
                {
                        if (len == 0)
                            continue;
                    lastword = len;
                    len = 0;
                }
                else
                    len++;
            }
            return len > 0 ? len : lastword;
        }
    }
}
