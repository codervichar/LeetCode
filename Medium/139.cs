using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        HashSet<string> set;
        int[] dp;

        public bool WordBreak(string s, IList<string> wordDict)
        {
            string origString = s;

            set = new HashSet<string>();
            dp = new int[s.Length];
            foreach(string temp in wordDict)
            {
                set.Add(temp);
            }

            return WordBreak(s) ;
        }

        public bool WordBreak(string s)
        {
            string word = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                word = s[i] + word;
                if (set.Contains(word))
                {
                    if (dp[i] == 0)
                    {
                        if (i==0 || WordBreak(s.Substring(0, i)))
                            dp[i] = 1;
                        else
                            dp[i] = -1;
                    }

                    if (dp[i] == 1)
                        return true;
                }
            }

            return false;
        }
    }
}
