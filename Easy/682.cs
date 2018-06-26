using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    partial class Solution
    {
        public int CalPoints(string[] ops)
        {
            if (ops == null)
                return 0;

            Stack<int> pointStack = new Stack<int>();
            int sum = 0;
			foreach(string temp in ops)
            {
				switch(temp)
                {
                    case "C":
                        int inValidPoint = pointStack.Pop();
                        sum -= inValidPoint;
                        break;

                    case "D":
                        int doublePoint = pointStack.Peek() * 2;
                        pointStack.Push(doublePoint);
                        sum += doublePoint;
                        break;

                    case "+":
                        int point1 = pointStack.Pop();
                        int point2 = pointStack.Peek();
                        pointStack.Push(point1);
                        pointStack.Push(point1 + point2);
                        sum += point1 + point2;

                        break;

                    default:
                        int point = System.Int32.Parse(temp);
                        pointStack.Push(point);
                        sum += point;
                        break;
                }
            }
            return sum;
        }
    }
}
