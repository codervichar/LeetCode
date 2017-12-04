using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    partial class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stk = new Stack<char>();
            foreach(char alpha in  s)
            {
                if (alpha == '(')
                    stk.Push(')');
                else if (alpha == '{')
                    stk.Push('}');
                else if (alpha == '[')
                    stk.Push(']');
                else if (stk.Count() == 0 || stk.Pop() != alpha)
                    return false;
            }
            return stk.Count() == 0;
        }
    }
}
