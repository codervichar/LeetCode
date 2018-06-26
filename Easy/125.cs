using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    partial class Solution
    {
        public bool IsPalindrome(string s)
        {
            if (s == null)
                return false;
            if (s.Length == 0)
                return true;

            int i = 0, j = s.Length - 1;
            int mid = s.Length / 2;
            while(i < j)
            {
                if (IsSpecialCharacter(s[i]))
                {
                    i++;
                    continue;
                }
                if(IsSpecialCharacter(s[j]))
                {
                    j--;
                    continue;
                }
                if (Char.ToLower(s[i]) != Char.ToLower(s[j]))
                    return false;
                i++;
                j--;
            }
            return true;
        }

        private bool IsSpecialCharacter(char spl)
        {
            if (spl == ' ' || spl == '.' || spl == ':' || spl == ':')
                return true;
            return false;
        }
    }
}
