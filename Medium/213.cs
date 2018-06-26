//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    partial class Solution
//    {
//        public class HouseRob
//        {
//            public int lastIndex, firstIndex, sum;
//        }

//        public int RobV2(int[] nums)
//        {
//            if (nums == null || nums.Length == 0)
//                return 0;
//            if (nums.Length == 1)
//                return nums[0];

//            HouseRob[,] dp = new HouseRob[nums.Length, nums.Length];

//            int maxValue = Int32.MinValue;

//            for (int i = 0; i < nums.Length; i++)
//            {
//                for (int j = 0; j <= i; j++)
//                {
//                    if (i < j)
//                        continue;

//                    if (i == 0 && j == 0)
//                    {
//                        dp[i, j] = new HouseRob() { sum = nums[0], firstIndex = 0, lastIndex = 0 };
//                    }   
//                    else
//                    {
//                        HouseRob val1, val2;

//                        if (i > 0 && j > 0 && dp[i - 1, j - 1].lastIndex != i - 1)
//                            val1 = new HouseRob() { sum = dp[i - 1, j - 1].sum + nums[i], lastIndex = i, firstIndex = dp[i - 1, j - 1].firstIndex };
//                        else if (i > 0 && j > 0)
//                            val1 = dp[i - 1, j - 1];
//                        else if (j == 0)
//                            val1 = Tuple.Create<int, int>(nums[i], i);

//                        if (i > 1 && j > 0 && i - 2 >= j - 1)
//                            val2 = Tuple.Create<int, int>(dp[i - 2, j - 1].Item1 + nums[i], i);


//                        val1 = val1.Item1 > val2.Item1 ? val1 : val2;

//                        if (i - 1 >= j)
//                            val2 = dp[i - 1, j];
//                        else
//                            val2 = Tuple.Create<int, int>(nums[i], i);

//                        if (val1.Item1 > val2.Item1)
//                            dp[i, j] = val1;
//                        else
//                            dp[i, j] = val2;
//                    }
//                    maxValue = maxValue < dp[i, j].Item1 ? dp[i, j].Item1 : maxValue;
//                }
//            }

//            return maxValue;
//        }
//    }
//}
