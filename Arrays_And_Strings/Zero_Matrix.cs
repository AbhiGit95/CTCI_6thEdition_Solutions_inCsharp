using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_and_Strings
{
    /*
     * Question : Write an algorithm such that if an element in an M * N matrix is 0, its entire row and column are set to 0.
     * Ask the interviewer if we can make inplace changes to the matrix and return it. 
     * The method implemented here makes inplace changes to the array.
     */
    class Zero_Matrix
    {

        public int[][] set_zero(int[][] matrix)
        {
            if(matrix == null || matrix.Length == 0 || matrix[0].Length == 0 )
            {
                return matrix;
            }

            HashSet<int> columns = new HashSet<int>();
            HashSet<int> rows = new HashSet<int>();

            int m = matrix.Length; int n = matrix[0].Length;

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(matrix[i][j] == 0)
                    {
                        columns.Add(j); rows.Add(i);
                    }
                }
            }

            IEnumerator<int> enumerator = rows.GetEnumerator();

            while(enumerator.MoveNext())
            {
                int temp_row = enumerator.Current;
                Array.Fill(matrix[temp_row], 0);

                //check if the column with this values exists or not.

                if(temp_row < n)
                {
                    for(int j = 0; j < m; j++)
                    {
                        matrix[j][temp_row] = 0;
                    }
                }

                //remove this value from columns_set inorder to avoid redundant work.

                if (columns.Contains(temp_row))
                    columns.Remove(temp_row);
            }

            IEnumerator<int> col_enum = columns.GetEnumerator();

            while(col_enum.MoveNext())
            {
                int temp_col = col_enum.Current;
                
                //check if the row with value temp_col exists

                if(temp_col < m && !rows.Contains(temp_col))
                {
                    Array.Fill(matrix[temp_col], 0);
                }

                for(int j = 0; j < m; j++)
                {
                    matrix[j][temp_col] = 0;
                }
            }

            return matrix;
        }

    }
}
