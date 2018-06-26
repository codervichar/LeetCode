using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        class Node
        {
            public int x, y;

            public Node(int x,int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        Stack<Node> stk = new Stack<Node>();

        public bool HasPath(int[,] maze, int[] start, int[] destination)
        {
            // start point
            stk.Push(new Node(start[0], start[1]));
            while(stk.Count >0)
            {
                Node temp = stk.Pop();
                
                if( temp.x == destination[0] && temp.y ==  destination[1])
                {
                    return true;
                }

                maze[temp.x, temp.y] = 2;

                GetAllDirections(maze, temp);
            }

            return false;
        }

        private void GetAllDirections(int[,] maze, Node node)
        {
            int rowLen = maze.GetLength(0), colLen = maze.GetLength(1);

            for(int i = node.y; i < colLen;i++)
            {
                if (i == colLen - 1)
                {
                    if(maze[node.x, i] == 0)
                        stk.Push(new Node(node.x, i));
                    break;
                }

                if (maze[node.x, i + 1] == 1)
                {
                    if(maze[node.x, i] == 0)
                        stk.Push(new Node(node.x, i));
                    break;
                }
            }

            for (int i = node.y; i >= 0; i--)
            {
                if (i == 0)
                {
                    if(maze[node.x, i] == 0)
                        stk.Push(new Node(node.x, i));
                    break;
                }

                if (maze[node.x, i - 1] == 1)
                {
                    if(maze[node.x, i] == 0)
                        stk.Push(new Node(node.x, i));
                    break;
                }
            }

            for (int i = node.x; i < rowLen; i++)
            {
                if (i == rowLen - 1)
                {
                    if(maze[i, node.y] == 0)
                        stk.Push(new Node(i, node.y));
                    break;
                }

                if (maze[i + 1, node.y] == 1)
                {
                    if(maze[i, node.y] == 0)
                        stk.Push(new Node(i, node.y));
                    break;
                }
            }

            for (int i = node.x; i >= 0; i--)
            {
                if (i == 0)
                {
                    if(maze[i, node.y] == 0)
                        stk.Push(new Node(i, node.y));
                    break;
                }

                if (maze[i-1, node.y] == 1)
                {
                    if(maze[i, node.y] == 0)
                        stk.Push(new Node(i, node.y));
                    break;
                }
            }
        }

    }
}
