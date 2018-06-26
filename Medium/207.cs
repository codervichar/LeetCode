//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    partial class Solution
//    {
      
//        public bool HasCycle2(List<List<int>> nodeList, int key, int value)
//        {
//            HashSet<int> tempSet = new HashSet<int>();
//            while( true)
//            {
//                if( nodeList[key] != null)
//                {
//                    //tempSet.Add(nodeList[key][])
//                }
//            }
//        }

//        public bool CanFinish(int numCourses, int[,] prerequisites)
//        {
//            List<List<int>> nodeList = new List<List<int>>();
//            HashSet<int> set = new HashSet<int>();

//            for (int i = 0; i < prerequisites.GetLength(0); i++)
//            {
//                int key = prerequisites[i, 0];
//                int value = prerequisites[i, 1];

//                if( set.Contains(key) && set.Contains(value))
//                {
//                    if (HasCycle2(nodeList, key, value))
//                    {

//                    }
//                }

//                if (!set.Contains(key))
//                    set.Add(key);

//                if (!set.Contains(value))
//                    set.Add(value);

//                if (nodeList[key] == null)
//                    nodeList[key] = new List<int>();

//                nodeList[key].Add(value);
//            }

//            return true;
//        }

//        class CourseNodeComparer : IEqualityComparer<CourseNode>
//        {
//            public bool Equals(CourseNode b1, CourseNode b2)
//            {
//                if (b2 == null && b1 == null)
//                    return true;
//                else if (b1 == null | b2 == null)
//                    return false;
//                else if (b1.key == b2.key && b1.value== b2.value)
//                    return true;
//                else
//                    return false;
//            }

//            public int GetHashCode(CourseNode obj)
//            {
//                int hCode = obj.key ^ obj.value;
//                return hCode.GetHashCode();
//            }
//        }
//    }
//}
