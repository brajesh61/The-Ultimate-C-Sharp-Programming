using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Find_the_pair_adjacent_largest_eleme
{
    internal class Program
    {
        /*
         * 57. Write a C# program to find the pair of adjacent elements that has the highest product of an array of integers.
         * 
         */
        static void Main(string[] args)
        {
            // Example array
            int[] array = { 1, -3, 4, -5, 1};

            // Check if the array has at least two elements
            if (array.Length < 2)
            {
                Console.WriteLine("Array must have at least two elements.");
                return;
            }

            // Initialize variables to store the maximum product and the index of the first element in the pair

            int maxProduct = array[0] * array[1];
            int maxIndex = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                int Product = array[i] * array[i + 1];
                if (Product > maxProduct)
                {
                    maxProduct = Product;
                    maxIndex = i;
                }
            }
            // Output the result
             Console.WriteLine($"The pair of adjacent elements with the largest product is: {array[maxIndex]} and {array[maxIndex + 1]}");
            Console.WriteLine($"The largest product is: {maxProduct}");

        }
    }
}
