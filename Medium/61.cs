using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return null;
            
            int len = 0;
            ListNode ptr = head;
            while(ptr != null)
            {
                ptr = ptr.next;
                len++;
            }
            k = (len <= k) ? (k % len) : k;
            
            if (k == 0)
                return head;
            k = (len - k);
            ptr = head;
            ListNode ptr1 = head, prev = head; ;
            while(k>0)
            {
                prev = ptr1;
                ptr1 = ptr1.next;
                k--;
            }

            head = ptr1;
            prev.next = null;
            while (ptr1.next != null)
                ptr1 = ptr1.next;
            ptr1.next = ptr;

            return head;
        }
    }
}
