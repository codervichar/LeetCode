using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            Dictionary<int, string> pad = new Dictionary<int, string>();
            pad.Add(1, "");
            pad.Add(2, "abc");
            pad.Add(3, "def");
            pad.Add(4, "ghi");
            pad.Add(5, "jkl");
            pad.Add(6, "mno");
            pad.Add(7, "pqrs");
            pad.Add(8, "tuv");
            pad.Add(9, "wxyz");
            pad.Add(0, "");

            return LetterCombine(digits, pad);
        }

        public IList<string> LetterCombine(string digits, Dictionary<int,string> pad)
        {
            List<string> alphaList = new List<string>();
            List<string> tempList = new List<string>();
            if (digits == null)
                return alphaList;

            foreach(char c in digits)
            {
                string alphabets = pad[Int32.Parse(c.ToString())];

                foreach(char alpha in alphabets)
                {
                    if( alphaList.Count > 0)
                        foreach(string str in alphaList)
                        {
                            tempList.Add(str + alpha);
                        }
                    else
                        tempList.Add(alpha.ToString());
                }
                alphaList = tempList;
                tempList = new List<string>();
            }
            return alphaList;
        }
    }
}
