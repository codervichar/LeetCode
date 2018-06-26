using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int CherryPickup(int[,] grid)
        {
            int x = grid.GetLength(0), y = grid.GetLength(1);

            if (grid[x - 1, y - 1] == -1 || grid[0,0] == -1)
                return 0;

            int[,] dp = new int[x, y];
            for(int i = 0;i<x;i++)
            {
                for(int j = 0; j<y;j++)
                {
                    if (grid[i, j] == -1)
                        continue;

                    if (i == 0 && j == 0)
                        continue;

                    if( j == 0 )
                    {
                        if (grid[i - 1, j] == -1)
                        {
                            grid[i, j] = -1;
                        }
                        else
                        {
                            grid[i, j] += grid[i - 1, j];
                            grid[i - 1, j] = 0;
                        }
                    }
                    else if( i == 0 )
                    {
                        if (grid[i, j - 1] == -1)
                        {
                            grid[i, j] = -1;
                        }
                        else
                        {
                            grid[i, j] += grid[i, j - 1];
                            grid[i, j - 1] = 0;
                        }
                    }
                    else if( grid[i-1,j] > grid[i,j-1] )
                    {
                        grid[i, j] += grid[i - 1, j];
                        grid[i - 1, j] = 0;
                    }
                    else
                    {
                        if(grid[i, j - 1] != -1)
                        {
                            grid[i, j] += grid[i, j - 1];
                            grid[i, j - 1] = 0;
                        }
                        else
                        {
                            grid[i, j] = -1;
                        }
                    }
                }
            }

            if (grid[x - 1, y - 1] == -1)
                return 0;

            for(int i=x-1;i>=0;i--)
            {
                for(int j=y-1;j>=0;j--)
                {
                    if (grid[i, j] == -1)
                        continue;

                    if (i == 0 && j == 0)
                        continue;

                    if (j == 0)
                    {
                        grid[i-1, j] += grid[i, j];
                        grid[i, j] = 0;
                    }
                    else if (i == 0)
                    {
                        grid[i, j-1] += grid[i, j];
                        grid[i, j] = 0;
                    }
                    else if (grid[i - 1, j] > grid[i, j - 1])
                    {
                        grid[i-1, j] += grid[i, j];
                        grid[i, j] = 0;
                    }
                    else
                    {
                        if (grid[i, j - 1] != -1)
                        {
                            grid[i, j - 1] += grid[i, j];
                            grid[i, j] = 0;
                        }
                        else
                        {
                            grid[i, j] = -1;
                        }
                    }
                }
            }

            return grid[0, 0];
        }
    }
}
