using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        public bool WordPattern(string pattern, string str)
        {
            Dictionary<char, string> patternValue = new Dictionary<char, string>();

            string[] words = str.Split(new char[] { ' ' });

            if (words.Length != pattern.Length)
            {
                return false;
            }

            for (int i = 0; i < words.Length; i++)
            {
                char alpha = pattern[i];

                if( patternValue.ContainsKey(alpha))
                {
                    if (!string.Equals(patternValue[alpha], words[i]))
                        return false;
                }
                else if( patternValue.ContainsValue(words[i]))
                {
                    return false;
                }
                else
                {
                    patternValue.Add(alpha, words[i]);
                }
            }

            return true;
        }
    }
}
