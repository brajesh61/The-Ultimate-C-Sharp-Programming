using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.Last___1st_int_equal_in_2_array
{
    internal class Program
    {
        /*
         * 49. Write a C# program to check if the first or the last element of the two arrays (length 1 or more) are equal.
        Test Data:
        Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
        Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
        Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal.
        Sample Output
        True
         */
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            int[] Array2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};

            Console.WriteLine(Array1[0].Equals(Array2[0]) || Array1[Array1.Length - 1].Equals(Array2[Array2.Length - 1]));
        }
    }
}
