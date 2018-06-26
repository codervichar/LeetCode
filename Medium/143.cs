using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public void ReorderList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return;
            }

            ListNode head1 = head, head2 = head.next, prevHead2 = null;

            /* Reverse first */
            while (head2 != null)
            {
                ListNode temp = null;
                if (head2.next != null && head2.next.next != null)
                {
                    head1.next = head2.next;

                    temp = head2.next.next;
                    head2.next = prevHead2;

                    prevHead2 = head2;
                    head2 = temp;
                    head1 = head1.next;
                }
                else if (head2.next != null && head2.next.next == null)
                {
                    head1.next = head2.next;
                    head2.next = prevHead2;
                    break;
                }
                else
                {
                    head1.next = head2.next;
                    head2.next = prevHead2;
                    break;
                }
            }

            head1 = head;
            while (head1.next != null && head2.next != null)
            {
                ListNode temp = head1.next;
                head1.next = head2;
                ListNode temp1 = head2.next;
                head2.next = temp;

                head1 = temp;
                head2 = temp1;
            }

            if (head1.next == null && head2.next == null)
                head1.next = head2;
            else if(head1.next != null && head2.next == null)
            {
                head2.next = head1.next;
                head1.next = head2;
            }
            else if (head1.next == null && head2.next != null)
            {
                head1.next = head2;
            }
        }
    }
}
