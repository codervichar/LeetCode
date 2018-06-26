using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stk = new Stack<int>();
            int returnVal = 0, num1 = 0, num2 = 0; ;

            if (tokens == null || tokens.Length == 0)
                return 0;
            if (tokens.Length == 1 && Int32.TryParse(tokens[0], out returnVal))
                return returnVal;


            foreach (String val in tokens)
            {
                switch(val)
                {
                    case "+":
                        num1 = stk.Pop();
                        num2 = stk.Pop();
                        returnVal =  (num1 + num2);
                        break;
                    case "-":
                        num1 = stk.Pop();
                        num2 = stk.Pop();
                        returnVal = (num2 - num1);
                        break;
                    case "*":
                        num1 = stk.Pop();
                        num2 = stk.Pop();
                        returnVal = (num1 * num2);
                        break;
                    case "/":
                        num1 = stk.Pop();
                        num2 = stk.Pop();
                        returnVal = (num2 / num1);
                        break;
                    default:
                        returnVal = Int32.Parse(val);
                        break;
                }
                stk.Push(returnVal);
            }

            if (stk.Count > 1)
                return stk.Pop();
            return 0;
        }
    }
}
