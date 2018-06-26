using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public bool HasCycle(ListNode head)
        {
            ListNode ptr1 = head, ptr2 = head;
            while (ptr1 != null && ptr2 != null)
            {
                ptr1 = ptr1.next;

                if (ptr2.next != null)
                    ptr2 = ptr2.next.next;
                else
                    break;

                if (ptr1 == ptr2)
                    return true;
            }
            return false;
        }
    }
}
