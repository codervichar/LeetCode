using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;

            ListNode tempHead = new ListNode(val+1);
            tempHead.next = head;

            ListNode cur = tempHead.next, prev = tempHead;
            while(cur != null)
            {
                if (cur.val == val)
                {
                    prev.next = cur.next;
                }
                else
                {
                    prev = cur;
                }
                cur = cur.next;
            }

            return tempHead.next;
        }
    }
}
