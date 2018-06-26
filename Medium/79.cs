using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool Exist(char[,] board, string word)
        {
            int row = board.GetLength(0), col = board.GetLength(1);

            for(int i = 0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    if(board[i,j] == word[0])
                    {
                        int[,] visited = new int[row, col];
                        if (Exist(board, visited, word, i, j))
                            return true;
                    }
                }
            }

            return false;
        }

        private bool Exist(char[,] board, int[,] visited, string word,int i, int j)
        {
            if(visited[i,j] == 0 && board[i,j] == word[0])
            {
                if (word.Length == 1)
                    return true;

                string wordSubStr = word.Substring(1);
                visited[i, j] = 1;

                if (i < board.GetLength(0)-1 && Exist(board, visited, wordSubStr, i + 1, j))
                    return true;
                if (j < board.GetLength(1)-1 && Exist(board, visited, wordSubStr, i, j+1))
                    return true;
                if (i > 0 && Exist(board, visited, wordSubStr, i-1, j))
                    return true;
                if (j > 0 && Exist(board, visited, wordSubStr, i, j - 1))
                    return true;

                visited[i, j] = 0;
            }
            return false;
        }
    }
}
