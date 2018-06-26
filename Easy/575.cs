using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int DistributeCandies(int[] candies)
        {
            int len = candies.Length;
            int mid = len / 2, kind = 0;

            Array.Sort(candies);
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int[] numList = new int[candies[len - 1]+1];

            int i = 0;
            for (i=0; i<len;i++)
            {
                if (dict.ContainsKey(candies[i]))
                    dict[candies[i]]++;
                else
                    dict[candies[i]] = 1;
            }

            var keys = new List<int>(dict.Keys);
            foreach(int key in keys)
            {
                if (kind == mid)
                    continue;

                if (dict[key] > 0)
                {
                    kind++;
                    dict[key]--;
                }
            }
            
            return kind;
        }
    }
}
