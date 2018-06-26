using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        // 1 -> 2 -> 3 -> 4 -> 5
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            int j = 1;
            ListNode temp = head, prevTail = null;

            while(temp != null && j<m)
            {
                prevTail = temp;
                temp = temp.next;
            }

            if (temp == null)
                return head;

            ListNode prevTemp = temp;
            temp = temp.next;
            
            while(temp != null && j<n)
            {
                ListNode temp1 = temp.next;

                temp.next = prevTemp;
                prevTemp = temp;

                temp = temp1;
                j++;
            }
            prevTail.next = temp;

            return head;
        }
    }
}
