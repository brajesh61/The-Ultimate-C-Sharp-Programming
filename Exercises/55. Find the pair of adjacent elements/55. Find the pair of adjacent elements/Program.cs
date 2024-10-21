using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.Find_the_pair_of_adjacent_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example array
        int[] array = { 3, 6, -2, -5, 7, 3 };

        // Check if the array has at least two elements
        if (array.Length < 2)
        {
            Console.WriteLine("Array must have at least two elements.");
            return;
        }

        // Initialize variables to store the maximum product and the index of the first element in the pair
        int maxProduct = array[0] * array[1];
        int maxIndex = 0;

        // Iterate through the array to find the maximum product of adjacent elements
        for (int i = 1; i < array.Length - 1; i++)
        {
            int product = array[i] * array[i + 1];
            if (product > maxProduct)
            {
                maxProduct = product;
                maxIndex = i;
            }
        }

        // Output the result
        Console.WriteLine($"The pair of adjacent elements with the largest product is: {array[maxIndex]} and {array[maxIndex + 1]}");
        Console.WriteLine($"The largest product is: {maxProduct}");
        Console.WriteLine($"The largest index is: {maxIndex}");
        }
    }
}
