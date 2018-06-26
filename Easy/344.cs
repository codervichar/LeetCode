using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public string ReverseString(string s)
        {
            int j = s.Length - 1;
            StringBuilder strTemp = new StringBuilder();
            while(j>0)
            {
                strTemp.Append(s[j]);
                j--;
            }
            return strTemp.ToString();
        }
    }
}
