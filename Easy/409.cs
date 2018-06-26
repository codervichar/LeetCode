using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int LongestPalindrome(string s)
        {
            if (s == null || s.Length == 0)
                return 0;
            else if (s.Length == 1)
                return 1;

            Dictionary<char, int> alphaCount = new Dictionary<char, int>();
            foreach(char temp in s)
            {
                if (alphaCount.ContainsKey(temp))
                    alphaCount[temp]++;
                else
                    alphaCount[temp] = 1;
            }

            char[] keyList = alphaCount.Keys.ToArray();

            int maxOdd = 0;
            int len = 0;
            foreach(char temp in keyList)
            {
                if (alphaCount[temp] % 2 == 0)
                    len += alphaCount[temp];
                else
                {
                    maxOdd = maxOdd > alphaCount[temp] ? maxOdd : alphaCount[temp];
                    len += alphaCount[temp] - 1;
                }
                    
            }
            if( maxOdd > 0)
                len++;

            return len;
        }
    }
}
