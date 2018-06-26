using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return string.Empty;

            string prefix = string.Empty, temp = strs[0];
            int j = 0;
            while (j < temp.Length)
            {
                for (int i = 0; i < strs.Length; i++)
                {
                    if (j < strs[i].Length)
                    {
                        if (temp[j] != strs[i][j])
                            return prefix;
                    }
                    else
                        return prefix;
                }
                prefix = prefix + temp[j];
                j++;
            }
            return prefix;
        }
    }
}
