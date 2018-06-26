using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int[,] FloodFill(int[,] image, int sr, int sc, int newColor)
        {
            int oldColor = image[sr, sc];

            FloodFill(image, sr, sc, newColor, oldColor);
            return image;
        }

        private void FloodFill(int[,] image, int sr, int sc, int newColor, int oldColor)
        {
            if (sr >= 0 && sr < image.GetLength(0) 
                && sc >= 0 && sc < image.GetLength(1) 
                && image[sr, sc] != newColor 
                && image[sr, sc] == oldColor)
            {
                image[sr, sc] = newColor;
                FloodFill(image, sr - 1, sc, newColor, oldColor);
                FloodFill(image, sr + 1, sc, newColor, oldColor);
                FloodFill(image, sr, sc - 1, newColor, oldColor);
                FloodFill(image, sr, sc + 1, newColor, oldColor);
            }
        }
    }
}
