using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodea
{
    partial class Solution
    {
        public int MinPathSum(int[,] grid)
        {
            int x = grid.GetLength(0), y = grid.GetLength(1);
            for (int i = 1; i < x; i++)
            {
                grid[i, 0] += grid[i - 1, 0];
            }

            for (int i = 1; i < grid.GetLength(1); i++)
            {
                grid[0, i] += grid[0, i - 1];
            }

            for (int i = 1; i < grid.GetLength(0); i++)
                for (int j = 1; j < grid.GetLength(1); j++)
                {
                    grid[i, j] += Math.Min(grid[i - 1, j], grid[i, j - 1]);
                }

            return grid[x - 1, y - 1];
        }
    }
}
