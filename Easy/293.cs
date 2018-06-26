using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public IList<string> GeneratePossibleNextMoves(string s)
        {
            List<string> outputList = new List<string>();

            for(int i=0;i<s.Length-1;i++)
            {
                if(s[i] == '+' && s[i+1] == '+')
                {
                    string prefix = (i==0) ? string.Empty: s.Substring(0, i);
                    string suffix = ((i+2)>= s.Length) ? string.Empty: s.Substring(i + 2);

                    outputList.Add(prefix + "--" + suffix);
                }
            }

            return outputList;
        }
    }
}
