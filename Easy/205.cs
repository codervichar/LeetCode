using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            if( s== null || s.Length == 0 || t == null || t.Length == 0)
                return true;

            if (s.Length != t.Length)
                return false;
            int[] l1 = new int[256], l2 = new int[256];

            for(int i=0;i<s.Length;i++)
            {
                if (l1[s[i]] != l2[t[i]])
                    return false;
                l1[s[i]] = i + 1;
                l2[t[i]] = i + 1;
            }
            return true;
        }
    }
}
