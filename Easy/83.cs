﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode temp = head;
            while(temp.next != null)
            {
                if( temp.val ==  temp.next.val)
                {
                    temp.next = temp.next.next;
                }
                else
                    temp = temp.next;
            }

            return head;
        }
    }
}
