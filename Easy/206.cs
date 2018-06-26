using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;
            if (head.next == null)
                return head;

            ListNode temp = head, nextTemp = temp.next, prevTemp = null;
            while( temp != null)
            {
                nextTemp = temp.next;
                temp.next = prevTemp;

                
                prevTemp = temp;
                temp = nextTemp;
            }
            return prevTemp;
        }
    }
}
