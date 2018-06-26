using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        public string GetHint(string secret, string guess)
        {
            Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();
            if (secret == null || guess == null || (secret.Length != guess.Length))
                return string.Empty;

            for(int i=0; i< secret.Length;i++)
            {
                if(!dict.ContainsKey(secret[i]))
                {
                    dict.Add(secret[i], new List<int>());
                }
                dict[secret[i]].Add(i);
            }

            int bulls =0, cows=0;
            List<int> bullIndex = new List<int>();
            for(int i=0;i<guess.Length;i++)
            {
                if(dict.ContainsKey(guess[i]))
                {
                    if (dict[guess[i]].Exists(x => x == i))
                    {
                        dict[guess[i]].Remove(i);
                        bullIndex.Add(i);
                        bulls++;
                    }
                }
            }
            for (int i = 0; i < guess.Length; i++)
            {
                if (dict.ContainsKey(guess[i]) && dict[guess[i]].Count >0 && !bullIndex.Exists(x => x == i))
                {
                    cows++;
                    dict[guess[i]].RemoveRange(0,1);
                }
            }
            return bulls + "A" + cows + "B";
        }
    }
}
