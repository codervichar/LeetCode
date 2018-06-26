using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;
            else if (l1 != null && l2 == null)
                return l1;
            else if (l1 == null && l2 != null)
                return l2;

            ListNode head = l1, ptr = l1;

            while (l1 != null && l2 != null)
            {
                if (l1.val >= l2.val)
                {
                    if (l1.val > l2.val)
                    {
                        /* Swap the numbers */
                        int temp = l1.val;
                        l1.val = l2.val;
                        l2.val = temp;
                    }

                    ListNode tempNode = l2.next;
                    l2.next = l1.next;
                    l1.next = l2;
                    l2 = tempNode;
                }
                ptr = l1;
                l1 = l1.next;
            }
            if (l1 == null && l2 != null)
                ptr.next = l2;
            return head;
        }
    }
}
