using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int UniquePaths(int m, int n)
        {
            int[,] box = new int[m, n];

            for (int i = 0; i < m; i++)
                box[i, 0] = 1;

            for (int j = 0; j < n; j++)
                box[0, j] = 1;

            for (int i=1;i < m;i++)
                for(int j=1;j<n;j++)
                {
                    int top = 0, left = 0;

                    top = box[i - 1, j];

                    left = box[i, j - 1];
                    box[i, j] = top + left;
                }

            return box[m - 1, n - 1];
        }
    }
}
