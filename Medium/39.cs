using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);

            IList<IList<int>> outputList = new List<IList<int>>();
            CombinationSum(candidates, 0, target, new List<int>(), outputList);
            return outputList;
        }

        public void CombinationSum(int[] candidates, int lo, int target, List<int> list, IList<IList<int>> outputList)
        {
            for (int i = lo; i < candidates.Length; i++)
            {
                list.Add(candidates[i]);

                if (candidates[i] == target)
                {
                    outputList.Add(new List<int>(list));
                }
                else if (candidates[i] < target)
                {
                    CombinationSum(candidates, i , target - candidates[i], list, outputList);
                }
                list.Remove(candidates[i]);
            }
        }
    }
}
