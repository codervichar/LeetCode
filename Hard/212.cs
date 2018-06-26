using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public IList<string> FindWords(char[,] board, string[] words)
        {
            List<string> wordList = new List<string>();
            foreach(string temp in words)
            {
                if (Exist(board, temp))
                    wordList.Add(temp);
            }

            return wordList;
        }
    }
}
