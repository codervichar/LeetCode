using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            StringBuilder number = new StringBuilder();

            if(num1.Length < num2.Length)
            {
                string temp = num2;
                num2 = num1;
                num1 = temp;
            }

            int carryOver = 0, i = num1.Length - 1, j = num2.Length - 1;
            for (; i >= 0; i--, j--)
            {
                int val1 = Int32.Parse(num1.Substring(i, 1)), val2 = 0;
                if (j >= 0)
                    val2 = Int32.Parse(num2.Substring(j, 1));

                int val = val1 + val2 + carryOver;
                number.Insert(0,val % 10);
                carryOver = val / 10;
            }

            if (carryOver > 0)
                number.Insert(0, carryOver);

            return number.ToString();
        }
    }
}
