using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public partial class Solution
    {
        public bool IsUgly(int num)
        {
            int divider = 2;
            if (num < 0)
                num = num * -1;
            while(num > 1 && divider <= num)
            {
                if(num % divider == 0)
                {
                    if (divider > 5)
                        return false;

                    while(num%divider == 0)
                    {
                        num = num / divider;
                    }
                }
                divider++;
            }

            return true;
        }
    }
}
