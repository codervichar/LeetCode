using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            int m = obstacleGrid.GetLength(0), n = obstacleGrid.GetLength(1);
            int[,] box = new int[m, n];

            for(int i=0; i< m;i++)
            {
                if (obstacleGrid[i, 0] == 0)
                {
                    box[i, 0] = 1;
                }
                else
                    break;
            }

            for (int j = 0; j < n; j++)
            {
                if (obstacleGrid[0, j] == 0)
                {
                    box[0, j] = 1;
                }
                else
                    break;
            }

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i, j] != 0)
                        continue;

                    int top = 0, left = 0;

                    top = box[i - 1, j];

                    left = box[i, j - 1];
                    box[i, j] = top + left;
                }

            return box[m - 1, n - 1];
        }
    }
}
