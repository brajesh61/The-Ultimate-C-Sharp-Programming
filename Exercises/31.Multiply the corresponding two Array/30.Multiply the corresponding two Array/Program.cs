using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Multiply_the_corresponding_two_Array
{
    internal class Program
    {
        /*
         * 31. Write a C# program to multiply the corresponding elements of two integer arrays.
        Sample Output:
        Array1: [1, 3, -5, 4]
        Array2: [1, 4, -5, -2]
        Multiply corresponding elements of two arrays:
            1 12 25 -8
        */
        static void Main(string[] args)
        {
            // Declare and initialize the first array with integer values
        int[] array1 = { 1, 3, -5, 4 };

            // Declare and initialize the second array with integer values
            int[] array2 = { 1, 4, -5, -2 };

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i] * array2[i]);
            }

        }
    }
}
