//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp
//{
//    public class Solution
//    {
//        IList<IList<int>> outputList = new List<IList<int>>();

//        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
//        {
//            Array.Sort(candidates);
//            CombinationSum2(candidates, 0, target, new List<int>());
//            return outputList;
//        }

//        public void CombinationSum2(int[] candidates, int lo, int target, List<int> list)
//        {
//            for (int i = lo; i < candidates.Length; i++)
//            {
//                list.Add(candidates[i]);

//                if (candidates[i] == target)
//                {
//                    outputList.Add(new List<int>(list));
//                }
//                else
//                {
//                    if (i == 0 || candidates[i] != candidates[i - 1])
//                    {
//                        CombinationSum2(candidates, i + 1, target - candidates[i], list);
//                    }
//                }
//                list.Remove(candidates[i]);
//            }

//            //IList<IList<int>> outputList = new List<IList<int>>();
//            //if (lo >= candidates.Length)
//            //    return outputList;

//            //if( candidates[lo] == target)
//            //{
//            //    outputList.Add(new List<int>());
//            //    outputList[0].Add(candidates[lo]);
//            //}
//            //else if( candidates[lo] < target )
//            //{
//            //    outputList = CombinationSum2(candidates, lo + 1, target - candidates[lo]);

//            //    if( outputList.Count > 0)
//            //    {
//            //        foreach(IList<int> list in outputList)
//            //        {
//            //            list.Add(candidates[lo]);
//            //        }
//            //    }
//            //}

//            //if (lo == 0 || candidates[lo] != candidates[lo - 1])
//            //{
//            //    var outputList2 = CombinationSum2(candidates, lo + 1, target);
//            //    outputList = outputList.Concat(outputList2).ToList();
//            //}

//            //return outputList;
//        }

//    }
//}
