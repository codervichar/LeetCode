using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public class BSTIterator
        {
            private Stack<TreeNode> stkIter;
            public BSTIterator(TreeNode root)
            {
                stkIter = new Stack<TreeNode>();
                TreeNode temp = root;
                if (temp != null)
                {
                    stkIter.Push(temp);
                    while (temp.left != null)
                    {
                        temp = temp.left;
                        stkIter.Push(temp);
                    }
                }
            }

            /** @return whether we have a next smallest number */
            public bool HasNext()
            {
                return stkIter.Count != 0;
            }

            /** @return the next smallest number */
            public int Next()
            {
                TreeNode temp = stkIter.Pop();
                TreeNode temp1 = temp;

                if(temp1.right != null)
                {
                    stkIter.Push(temp1);
                    while(temp1.left != null)
                    {
                        temp1 = temp1.left;
                        stkIter.Push(temp1);
                    }
                }
                return temp.val;
            }
        }
    }
}
