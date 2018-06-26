using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        int count = 0;
        public int CountArrangement(int N)
        {
            bool[] used = new bool[N + 1];
            List<int> list = new List<int>();
            list.Add(0);

            CountArrangement(N, list, used);

            return count;
        }

        public int CountArrangement(int n, List<int> list,bool[] used)
        {
            if (list.Count() > n)
            {
                count++;
                return 0;
            }

            int i = list.Count();

            for (int j = 1; j <= n; j++)
            {
                if (used[j] == false && (i % j == 0 || j % i == 0))
                {
                    list.Add(j);
                    used[j] = true;
                    CountArrangement(n, list,used);
                    used[j] = false;
                    list.RemoveAt(list.Count() - 1);
                }
            }
            return 0;
        }
    }
}
