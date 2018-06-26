using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            Dictionary<char, int> charList = new Dictionary<char, int>();

           
            if (tasks == null)
                return 0;
            foreach(char c in tasks)
            {
                if (charList.ContainsKey(c))
                    charList[c]++;
                else
                    charList[c] = 1;
            }

            int timer = 0;
            int[] alphaList = new int[26];
            while (true)
            {
                bool update = false;
                var keys = charList.Keys.ToArray();
                foreach (char key in keys)
                {
                    if (charList[key] == 0)
                        continue;

                    update = true;
                    charList[key]--;
                    int index = (key - 'A') % 26;
                    if (alphaList[index] != 0 && timer - alphaList[index] < n)
                    {
                        timer += (n - (timer - alphaList[index]));
                    }
                    timer++;

                    alphaList[index] = timer;
                }

                if (!update)
                    break;
            }

            return timer;
        }
    }
}
