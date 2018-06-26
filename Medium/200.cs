using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        
        
        public int NumIslands(char[,] grid)
        {
            int islandCount = 0;
            int rowLen = grid.GetLength(0), colLen = grid.GetLength(1);
            for(int i = 0; i< rowLen;i++)
            {
                for(int j=0; j< colLen;j++)
                {
                    if( grid[i,j] == '1')
                    {
                        islandCount++;
                        NumIslands(grid, i, j);
                    }
                }
            }

            return islandCount;
        }

        private void NumIslands(char[,] grid, int i, int j)
        {
            if (i >= grid.GetLength(0) || j >= grid.GetLength(1) || i <0 || j<0)
                return;
            if (grid[i, j] != '1')
                return;

            grid[i, j] = 'a';
            NumIslands(grid, i+1, j);
            NumIslands(grid, i, j+1);
            NumIslands(grid, i-1, j);
            NumIslands(grid, i, j-1);
        }
    }
}