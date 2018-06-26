using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            int x = dungeon.GetLength(0), y = dungeon.GetLength(1);

            for(int i=1;i<x;i++)
            {
                dungeon[i][0] += dungeon[i - 1][0]; 
            }

            for (int j = 1; j < y; j++)
            {
                dungeon[0][j] += dungeon[0][j-1];
            }

            for (int i = 1; i < x; i++)
                for (int j = 1; j < y; j++)
                {
                    dungeon[i][j] += Math.Min(Math.Abs(dungeon[i - 1][ j]), Math.Abs(dungeon[i][ j-1]));
                }

            return (dungeon[x - 1][ y - 1] >= 0 ? 0 : Math.Abs(dungeon[x - 1][ y - 1]));
        }
    }
}
