using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode ptr1 = head, ptr2 = head;

            while(n>0 && ptr2.next != null)
            {
                n--;
                ptr2 = ptr2.next;
            }

            if (n > 1)
                return head;

            while (ptr2.next != null)
            {
                ptr2 = ptr2.next;
                ptr1 = ptr1.next;
            }

            if (head == ptr1)
                head = head.next;
            else
                ptr1.next = ptr1.next.next;
            return head;
        }
    }
}
