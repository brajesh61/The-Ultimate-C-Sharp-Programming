using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Checks_how_many_integers
{
    internal class Program
    {
        //57. Write a C# program to find the pair of adjacent elements that has the highest product of an array of integers.
        //Explanation: The complete range from 1 to 7 is {1, 2, 3, 4, 5, 6, 7}, and the missing numbers are {2, 4, 6}, so 3 numbers are needed.
        static void Main(string[] args)
        {
            // Prompt the user to enter a list of integers separated by spaces
            Console.Write("Enter a list of integers (separated by spaces): ");
            string input = Console.ReadLine();

            // Convert the input string into an array of integers
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            // Find the minimum and maximum values in the list
            int min = numbers.Min();
            int max = numbers.Max();

            // Calculate the total numbers in the range
            int totalNumbersInRange = (max - min) + 1;

            // Calculate how many numbers are needed to complete the range
            int numbersNeeded = totalNumbersInRange - numbers.Length;

            // Find the missing numbers in the range
            List<int> missingNumbers = new List<int>();

            for (int i = min; i <= max; i++)
            {
                if (!numbers.Contains(i))
                {
                    missingNumbers.Add(i);
                }
            }

            // Output the missing numbers
            if (missingNumbers.Count > 0)
            {
                Console.WriteLine("The missing numbers are: " + string.Join(", ", missingNumbers));
                // Output the result
                Console.WriteLine($"The number of integers needed to complete the range is: {numbersNeeded}");
               
            }
            else
            {
                Console.WriteLine("There are no missing numbers.");
            }
            Console.ReadLine();
        }
    }
}
