using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            int c = 0;
            for(int i=0;i<s.Length;i++)
            {
                c = c ^ s[i];
            }

            for (int i = 0; i < t.Length; i++)
            {
                c = c ^ t[i];
            }
            return (char)c;
        }
    }
}
