using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        private bool IsRowTrue(bool[,] dp, int k,int  col)
        {
            for(int j=0;j<=col;j++)
            {
                if (dp[k, j])
                    return true;
            }
            return false;
        }

        public bool WildCardMatch(string s, string p)
        {
            bool[,] dp = new bool[p.Length+1, s.Length + 1];
            dp[0, 0] = true;

            for(int i=1;i<=p.Length;i++)
            {
                char pattern = p[i - 1];

                for (int j=0;j<=s.Length;j++)
                {
                    char str = (j == 0) ? ' ' : s[j - 1];
                    bool prevRow = IsRowTrue(dp, i - 1, j);

                    if (pattern == '*')
                    {
                        dp[i, j] = prevRow && true;
                    }
                    else if( pattern == '?' || pattern == str)
                    {
                        dp[i, j] = ((j==0) ? false :dp[i - 1, j - 1]) && true;
                    }
                }
            }

            return dp[p.Length, s.Length];
        }
    }
}
