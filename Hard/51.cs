//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    partial class Solution
//    {
//        public IList<IList<string>> SolveNQueens(int n)
//        {
//            bool[,] chess = new bool[n,n];
//            int[,] position = new int[n,n];

//            SolveNQueens(position, chess, 0);
//        }

//        public void  SolveNQueens(int[,] position, bool[,] chess, int col)
//        {
//            if(col == position.GetLength(0))
//            {
//                //Add to list
//                return;
//            }

//            for(int i=0; i < position.GetLength(0); i++)
//            {
//                if(!chess[i,col])
//                {
//                    chess[i, col] = true;
//                    SolveNQueens(position, chess, col + 1);

//                    chess[i, col] = false;
                    
//                }
//            }
//        }
//    }
//}
