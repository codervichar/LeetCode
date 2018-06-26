using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        private bool IsVowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                return true;
            return false;
        }

        public string ReverseVowels(string s)
        {
            int i = 0, j = s.Length-1, len = s.Length;
            StringBuilder newStr = new StringBuilder(s);

            while(true)
            {
                while (i < len && !IsVowel(s[i]))
                    i++;
                while (j >= 0 && !IsVowel(s[j]))
                    j--;

                if (i >= j)
                    break;
                char temp = newStr[i];
                newStr[i] = newStr[j];
                newStr[j] = temp;
                i++;
                j--;
            }

            return newStr.ToString();
        }
    }
}
