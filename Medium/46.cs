using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            bool[] used = new bool[nums.Length];

            IList<IList<int>> permList = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return permList;

            Permute(nums, 0, nums.Length - 1,used, permList, new List<int>());

            return permList;
        }

        public void Permute(int[] nums, int lo, int hi,bool[] used, IList<IList<int>> permList, IList<int> list)
        {
            for(int i=lo;i<=hi;i++)
            {
                if (used[i])
                    continue;
                used[i] = true;

                list.Add(nums[i]);
                
                if( list.Count == nums.Length)
                {
                    permList.Add(new List<int>(list));
                }
                else
                {
                    Permute(nums, lo, hi, used, permList, list);
                }

                list.Remove(nums[i]);
                used[i] = false;
            }

            //IList<IList<int>> numList = new List<IList<int>>();

            //if (hi < lo)
            //    return numList;

            //for(int i=lo;i<=hi;i++)
            //{
            //    int j = nums[i];

            //    var tempList2 = Permute(nums, i + 1, hi);
            //    var tempList1 = Permute(nums, lo, i-1);

            //    if( tempList1.Count >0  && tempList2.Count >0)
            //    {
            //        foreach(List<int> list1 in tempList1)
            //            foreach(List<int> list2 in tempList2)
            //            {
            //                var list = new List<int>();
            //                list.Add(j);
            //                list.AddRange(list1);
            //                list.AddRange(list2);

            //                numList.Add(list);

            //                list = new List<int>();
            //                list.Add(j);
            //                list.AddRange(list2);
            //                list.AddRange(list1);

            //                numList.Add(list);
            //            }
            //    }
            //    else if(tempList1.Count>0)
            //    {
            //        foreach (List<int> list1 in tempList1)
            //        {
            //            var list = new List<int>();
            //            list.Add(j);
            //            list.AddRange(list1);
            //            numList.Add(list);
            //        }
            //    }
            //    else if(tempList2.Count>0)
            //    {
            //        foreach (List<int> list1 in tempList2)
            //        {
            //            var list = new List<int>();
            //            list.Add(j);
            //            list.AddRange(list1);
            //            numList.Add(list);
            //        }
            //    }
            //    else
            //    {
            //        numList.Add(new List<int>() { j });
            //    }
            //}

            //return numList;
        }
    }
}
