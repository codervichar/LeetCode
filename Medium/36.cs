using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool IsValidSudoku(char[,] board)
        {
            for (int i=0;i<board.GetLength(0);i++)
            {
                HashSet<char> charSet = new HashSet<char>();
                for (int j=0;j<board.GetLength(1); j++)
                {
                    if (charSet.Contains(board[i,j]))
                    {
                        return false;
                    }
                    else if (board[i, j] != '.')
                    {
                        charSet.Add(board[i, j]);
                    }

                    if (i%3 == 0 && j%3 == 0 && !IsValidSudoku(board, i, j))
                        return false;

                    HashSet<char> charSet2 = new HashSet<char>();
                    for (int k = 0; k < board.GetLength(0) && i==0; k++)
                    {
                        if (charSet2.Contains(board[k, j]))
                        {
                            return false;
                        }
                        else if (board[k, j] != '.')
                        {
                            charSet2.Add(board[k, j]);
                        }
                    }
                }
            }

            return true;
        }

        public bool IsValidSudoku(char[,] board, int i , int j)
        {
            HashSet<char> charSet = new HashSet<char>();
            for(int k=i;k<i+3;k++)
            {
                for (int l = j; l < j + 3;l++)
                {
                    if( charSet.Contains(board[k,l]))
                    {
                        return false;
                    }
                    else if( board[k,l] != '.')
                    {
                        charSet.Add(board[k, l]);
                    }
                }
            }
            return true;
        }
    }
}
