using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    partial class Solution
    {
        public string ConvertToBase7(int num)
        {
            int input = Math.Abs(num);
            StringBuilder output = new StringBuilder();

            while(input>=7)
            {
                output.Insert(0,(input % 7));
                input = input / 7;
            }

            output.Insert(0, input);
            if (num < 0)
                output.Insert(0, '-');

            string outputStr = output.ToString();
            
            return outputStr;
        }
    }
}
