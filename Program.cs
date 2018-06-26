using System;
using System.Collections.Generic;
using System.Linq;
    
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;
using LeetCode.Medium;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class CortanaCard
    {
        public int[] list = new int[] {1,2,3};
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(10);

            Dictionary<int, ListNode> listMap = new Dictionary<int, ListNode>();
            listMap.Add(1, node);
            node.val = 11;
            Console.WriteLine(listMap[1].val);

            TreeNode root = new TreeNode(1);
            ///root.left = new TreeNode(2);
            root.right = new TreeNode(2);

            //root.left.left = new TreeNode(2);

            //root.right.left = new TreeNode(2);
            root.right.right = new TreeNode(3);

            //root.left.left.left = new TreeNode(3);
            ////root.left.right.right = new TreeNode(4);

            root.right.right.right = new TreeNode(4);
            root.right.right.right.right = new TreeNode(5);
            int[] cost = new int[] { 2, 2, 1, 1, 1, 2, 2 };

            char[,] board = new char[,]{{'.','.', '4', '.', '.', '.', '6', '3', '.'},
                                        {'.','.', '.', '.', '.', '.', '.', '.', '.'},
                                        {'5','.', '.', '.', '.', '.', '.', '9', '.'},
                                        {'.','.', '.', '5', '6', '.', '.', '.', '.'},
                                        {'4','.', '3', '.', '.', '.', '.', '.', '1'},
                                        {'.','.', '.', '7', '.', '.', '.', '.', '.'},
                                        {'.','.', '.', '5', '.', '.', '.', '.', '.'},
                                        {'.','.', '.', '.', '.', '.', '.', '.', '.'},
                                        {'.','.', '.', '.', '.', '.', '.', '.', '.'}};


            //string[] list = new string[] { "3", "30", "34", "5","9"};

            int[,] pre = new int[,] { { 0, 0, 0 }, { 0,1,0 },{ 0,0,0 } };

            int[] list = new int[] { 4, 3, 1, 4, 2};
            Solution sol = new Solution();

            var answer = sol.ValidIPAddress("256.256.256.256");

            // sol = new Solution();
            //var list = sol.MajorityElement(cost);
            //int[] cost = new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            //var node = sol.MinCostClimbingStairs(cost);
            /*
            Solution sol = new Solution();
            sol.GetMinimumDifference(root);
            */

            //ListNode first = new ListNode(1);

            //ListNode second = new ListNode(2);
            //first.next = second;
            //second.next= new ListNode(3);
            //second.next.next = new ListNode(4);
            //second.next.next.next = new ListNode(5);
            //ListNode third = new ListNode(5);

            //third.next = new ListNode(2);
            //third.next.next = new ListNode(3);



            //char[,] grid = new char[,] { { '1', '1', '1' }, { '0', '1', '0'}, {'1', '1', '1'} };

            //int[] cost = new int[] { 183, 219, 57, 193, 94, 233, 202, 154, 65, 240, 97, 234, 100, 249, 186, 66, 90, 238, 168, 128, 177, 235, 50, 81, 185, 165, 217, 207, 88, 80, 112, 78, 135, 62, 228, 247, 211};
            //Solution sol = new Solution();
            //var val = sol.Rob(cost);
            //var text = sol.NumIslands(grid);

            //var val = sol.WidthOfBinaryTree(nums,8);

        }


        public static string sort(string inputWord)
        {
            char[] input = inputWord.ToCharArray();

            for (int i = 1; i < input.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (input[j] < input[j - 1])
                    {
                        char temp = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = temp;
                    }
                }
            }

            return input.ToString();
        }
    }
}
