/*
 * https://leetcode.com/problems/generate-parentheses/description/
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            string bracket = "(";
            return GenerateParenthesis(n, 1, 0, bracket);
        }

        public IList<string> GenerateParenthesis(int n, int open, int close, string bracket)
        {
            IList<string> tempList = new List<string>();

            if (n > open)
            {
                var list = GenerateParenthesis(n, open + 1, close, bracket + "(");
                tempList = tempList.Concat(list).ToList();
            }
            if (n > close && open > close)
            {
                var list = GenerateParenthesis(n, open, close + 1, bracket + ")");
                tempList = tempList.Concat(list).ToList();
            }

            if (n == open && n == close)
            {
                tempList.Add(bracket);
            }
            return tempList;
        }
    }
}