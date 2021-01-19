using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    /*
     * Question - Given an image represented by an N * N matrix where each pixel in the image is represented by an integer. Write a method to rotate the image 
     * by 90 degrees. Can you do this in place?     */ 
    class Rotate_Matrix
    {
        public int[][] rotate_matrix(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return matrix;

            int n = matrix.Length;

            for(int layer = 0; layer < n / 2; layer ++)
            {
                int first = layer;
                int last = n - 1 - layer;

                for(int i = first; i < last; i++)
                {
                    int offset = i - first;

                    int top = matrix[first][i];

                    matrix[first][i] = matrix[last - offset][first];

                    matrix[last - offset][first] = matrix[last][last - offset];

                    matrix[last][last - offset] = matrix[i][last - last];

                    matrix[i][last] = top;
                }
            }

            return matrix;
        }
    }
}
