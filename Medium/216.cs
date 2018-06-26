using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            List<IList<int>> outputList = new List<IList<int>>();

            CombinationSum3(k, 1, n, new List<int>(), outputList);

            return outputList;
        }

        public void CombinationSum3(int k, int lo, int n, List<int> list, IList<IList<int>> outputList)
        {
            for (int i = lo; i <= 9; i++)
            {
                list.Add(i);

                if (k == 1 && i == n)
                {
                    outputList.Add(new List<int>(list));
                }
                else if( k > 1 && i < n)
                {
                    CombinationSum3(k-1, i + 1, n - i, list, outputList);
                }

                list.Remove(i);
            }
        }
    }
}
