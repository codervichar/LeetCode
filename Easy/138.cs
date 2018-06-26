using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    partial class Solution
    {
        public class RandomListNode
        {
            public int label;
            public RandomListNode next, random;
            public RandomListNode(int x) { this.label = x; }
        };

        public RandomListNode CopyRandomList(RandomListNode head)
        {
            RandomListNode oldNode = head;
            RandomListNode newNode = new RandomListNode(oldNode.label);
            RandomListNode newHead = newNode;
            Dictionary<RandomListNode, RandomListNode> dict = new Dictionary<RandomListNode, RandomListNode>();
            dict.Add(oldNode, newNode);
            while(oldNode.next != null)
            {
                oldNode = oldNode.next;

                RandomListNode temp = new RandomListNode(oldNode.label);
                newNode.next = temp;
                newNode = temp;
                dict.Add(oldNode, temp);
            }

            oldNode = head;
            newNode = newHead;
            while (oldNode != null)
            {
                if( oldNode.random != null)
                {
                    if( dict.ContainsKey(oldNode.random))
                    {
                        newNode.random = dict[oldNode.random];
                    }
                }

                RandomListNode temp = new RandomListNode(oldNode.label);
                newHead.next = temp;
                newHead = temp;
                dict.Add(oldNode, temp);

                oldNode = oldNode.next;
                newNode = newNode.next;
            }

            return newHead;
        }
    }
}
