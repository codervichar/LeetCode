using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return head;
            ListNode odd = head, even = head.next, evenHeader = head.next;
            int i = 1;
			while(odd !=  null && even !=  null)
            {
                if (i%2 == 0)
                {
                    even.next = odd.next;
                    even = even.next;
                }
                else
                {
                    odd.next = even.next;
                    if (odd.next == null)
                        break;
                    odd = odd.next;
                }
                i++;
            }
			odd.next = evenHeader;
            return head;
        }
    }
}
