using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
            public IList<TreeNode> GenerateTrees(int n)
            {
                int[] nums = new int[n];
                for (int i = 0; i < n; i++)
                    nums[i] = i+1;

                return GenerateTrees(nums, 0, nums.Length - 1);
            }

            public IList<TreeNode> GenerateTrees(int[] nums, int lo, int hi)
            {
                IList<TreeNode> treeList = new List<TreeNode>();

                if (hi < lo)
                    return treeList;

                for(int i=lo;i<=hi;i++)
                {
                    var leftTree = GenerateTrees(nums, lo, i - 1);
                    var rightTree = GenerateTrees(nums, i + 1, hi);
                    if (leftTree.Count > 0 && rightTree.Count > 0)
                    {
                        foreach (TreeNode temp1 in leftTree)
                            foreach (TreeNode temp2 in rightTree)
                            {
                                TreeNode root = GetTree(nums[i], temp1, temp2);
                                treeList.Add(root);
                            }
                    }
                    else if(leftTree.Count>0)
                    {
                        foreach (TreeNode temp in leftTree)
                        {
                            TreeNode root = GetTree(nums[i], temp, null);
                            treeList.Add(root);
                        }
                    }
                    else if(rightTree.Count>0)
                    {
                        foreach (TreeNode temp in rightTree)
                        {
                            TreeNode root = GetTree(nums[i], null, temp);
                            treeList.Add(root);
                        }
                    }
                    else
                    {
                        TreeNode root = GetTree(nums[i], null, null);
                        treeList.Add(root);
                    }
                }

                return treeList;
            }

            private static TreeNode GetTree(int val, TreeNode temp1, TreeNode temp2)
            {
                TreeNode root = new LeetCode.TreeNode(val);
                root.left = temp1;
                root.right = temp2;
                return root;
            }
    }
}
