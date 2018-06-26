//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    partial class Solution
//    {
//        public ListNode Sort(ListNode ptr1, int len)
//        {
//            int i = 0;
//            ListNode ptr2 = ptr1;

//            while (i < len/2)
//            {
//                ptr2 = ptr2.next;
//                i++;
//            }
//            i = 0;
//            while (i < len && ptr2 != null)
//            {
//                if (ptr1 != null)
//                {
//                    if (ptr1.val <= ptr2.val)
//                    {
//                        ptr1 = ptr1.next;
//                        i++;
//                    }
//                    else
//                    {
//                        int temp = ptr1.val;
//                        ptr1.val = ptr2.val;
//                        ptr2.val = temp;
//                    }
//                }
//                else
//                {
//                    if (ptr2.next != null && ptr2.val > ptr2.next.val)
//                    {
//                        int temp = ptr1.val;
//                        ptr1.val = ptr2.val;
//                        ptr2.val = temp;
//                    }
//                    else
//                    {
//                        ptr2 = ptr2.next;
//                        i++;
//                    }
//                }
//            }
//        }

//        public ListNode SortList(ListNode head)
//        {
//            ListNode ptr1 = head;
            
//            // Get Len
//            int len = 0;
//            while (ptr1 != null)
//            {
//                len++;
//                ptr1 = ptr1.next;
//            }

//            int j = 2 ;

//            while (j < len)
//            {
//                int i = 0;
//                ptr1 = head;
//                while (i < len && ptr1 != null)
//                {
//                    ListNode tempNode = ptr1;
//                    ptr1 = Sort(tempNode, j);
//                    i += j;
//                }
//                j *= 2;
//            }

//            return head;
//        }
//    }
//}
