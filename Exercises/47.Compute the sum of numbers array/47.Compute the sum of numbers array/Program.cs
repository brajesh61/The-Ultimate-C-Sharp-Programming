using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.Compute_the_sum_of_numbers_array
{
    internal class Program
    {
        /*
         * 47. Write a C# program to compute the sum of all the elements of an array of integers.
        Test Data:
        Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
        Sample Output
        Sum: 69
         */
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();
        }
    }
}
