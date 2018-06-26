using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int IslandPerimeter(int[,] grid)
        {
            int perimeter = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 1)
                    {
                        perimeter = IslandPerimeter(grid, i, j);
                    }
                }

            return perimeter;
        }

        private int IslandPerimeter(int[,] grid,int i,int j)
        {
            if (i >= 0 && i < grid.GetLength(0) && j >= 0 && j < grid.GetLength(1))
            {
                if (grid[i, j] == 0)
                {
                    return 1;
                }
                else if (grid[i, j] == -1)
                {
                    return 0;
                }
                else if (grid[i, j] == 1)
                {
                    grid[i, j] = -1;
                    return IslandPerimeter(grid, i + 1, j) +
                        IslandPerimeter(grid, i - 1, j) +
                        IslandPerimeter(grid, i, j - 1) +
                        IslandPerimeter(grid, i, j + 1);
                }
            }
            return 1;
        }
    }
}
