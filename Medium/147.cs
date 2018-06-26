using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public ListNode InsertionSortList(ListNode head)
        {
            ListNode ptr1 = head;
            int len = 0;
            while (ptr1 != null)
            {
                len++;
                ptr1 = ptr1.next;
            }
            ptr1 = head;
            for (int i = len-1; i > 0; i--)
            {
                int j = i-1;
                while(j > 0)
                {
                    ptr1 = ptr1.next;
                    j--;
                }

                while(ptr1.next != null && ptr1.val > ptr1.next.val)
                {
                    int temp = ptr1.val;
                    ptr1.val = ptr1.next.val;
                    ptr1.next.val = temp;

                    ptr1 = ptr1.next;
                }
                ptr1 = head;
            }
            return head;
        }
    }
}
