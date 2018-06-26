using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int GetMin(int[,] dp, int i, int j, bool[] yaxis, bool[] xaxis, bool isMatch)
        {
            int top = Int32.MaxValue, left = Int32.MaxValue, corner = Int32.MaxValue;

            if ( i==0 && j!=0)
            {
               left = dp[i, j - 1];
            }
            else if( i!=0 && j==0)
            {
                top = dp[i - 1, j];
            }
            else if(i!= 0 && j!=0)
            {
                top = dp[i - 1, j];
                left = dp[i, j - 1];
                corner = dp[i-1,j-1];
            }
            else if(i==0 && j==0)
            {
                return 0;
            }

            int min = Math.Min(top, left)+1;

            if (isMatch)
            {
                return Math.Min(corner, min);
            }
            else
            {
                return min;
            }
        }

        public int MinDistance(string word1, string word2)
        {
            word1 = " " + word1;
            word2 = " " + word2;

            int[,] dp = new int[word1.Length, word2.Length];
            bool[] yaxis = new bool[word1.Length];
            bool[] xaxis = new bool[word2.Length];

            int last = 0;
            for(int i=0;i<word1.Length;i++)
            {
                for(int j=0;j<word2.Length;j++)
                {
                    dp[i, j] = GetMin(dp, i, j, yaxis, xaxis, word1[i] == word2[j]);
                    last = dp[i, j];
                    Console.Write(dp[i, j] + "\t");
                }
                Console.WriteLine("");
            }

            return last;
        }
    }
}
