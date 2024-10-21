using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60.Calculate_the_sum_of_rectangular_matrix
{
    internal class Program
    {
        /*
         * 60. Write a C# program to calculate the sum of all integers in a rectangular matrix. However, exclude those integers located below an integer of value 0.
            Sample Example:
            matrix = [[0, 2, 3, 2],
            [0, 6, 0, 1],
            [4, 0, 3, 0]]
            Eligible integers which will be participated to calculate the sum -
            matrix = [[X, 2, 3, 2],
            [X, 6, X, 1],
            [X, X, X, X]]
            Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14
         * 
         */
        static void Main(string[] args)
        {
            Console.Title = "Sum of matrix, excluding integers 0";
          
            // Example matrix
            int[,] matrix = {
            { 0, 2, 3, 2 },
            { 0, 6, 0, 1 },
            {4, 0, 3, 0 }
        };

            // Calculate the sum excluding numbers below 0
            int sum = CalculateSumExcludingBelowZero(matrix);

            // Output the result
            Console.WriteLine($"The sum of the matrix is: {sum}");
            Console.ReadLine();
        }
        static int CalculateSumExcludingBelowZero(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;

            // Iterate over each column
            for ( int col  = 0; col < cols; col++ )
            {
                //// Iterate over each row in the column
                for (int row = 0; row < rows; row++)
                {
                    
                  if (matrix[row, col] == 0)
                    {
                        break;
                    }
                    // Add the value to the sum
                    sum += matrix[row, col];
                }
            }
            return sum;

        }
    }
    
}
