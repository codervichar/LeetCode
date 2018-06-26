using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool CircularArrayLoop(int[] nums)
        {
            int index = 0, startIndex = 0, len = nums.Length;

            while (true)
            {
                startIndex = index;

                while(true)
                {
                    int temp = nums[index]%len;


                }
            }
        }
    }
}
