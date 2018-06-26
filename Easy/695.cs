using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MaxAreaOfIsland(int[,] grid)
        {
            int maxArea = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if( grid[i, j] == 1)
                    {
                        int area = AreaOfIsland(grid, i, j);
                        maxArea = Math.Max(maxArea, area);
                    }
                }

            return maxArea;
        }

        private int AreaOfIsland(int[,] grid, int i, int j)
        {
            if (i >= 0 && i < grid.GetLength(0) && j >= 0 && j < grid.GetLength(1))
            {
                if(grid[i,j] == 1)
                {
                    grid[i, j] = 0;
                    return 1 + AreaOfIsland(grid, i + 1, j) +
                        AreaOfIsland(grid, i - 1, j) +
                        AreaOfIsland(grid, i, j - 1) +
                        AreaOfIsland(grid, i, j + 1);
                }
            }
            return 0;
        }
    }
}
