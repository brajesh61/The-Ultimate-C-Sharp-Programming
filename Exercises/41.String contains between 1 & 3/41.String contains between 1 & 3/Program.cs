using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.String_contains_between_1___3
{
    internal class Program
    {
        /*
         * 41. Write a C# program to check if a given string contains the 'w' character between 1 and 3 times.
            Test Data:
            Input a string (contains at least one 'w' char) : w3resource
            Test the string contains 'w' character between 1 and 3 times:
            Sample Output
            True
        */
        static void Main(string[] args)
        {
            // Prompt the user to input a string containing at least one 'w' character
            Console.Write("Input a string (contains at least one 'w' char) : ");

            // Read the input string and store it in the variable 'str'
            string str = Console.ReadLine();

            // Count the occurrences of the character 'w' in the input string and store the count in 'count'
            //var count = str.Count(s => s == 'w');
            var count = 0;
            foreach (var item in str)
                if (item == 'w')
                {
                    count++;
                }

            // Display a message indicating the test for the presence of 'w' character between 1 and 3 times
            Console.WriteLine("Test the string contains 'w' character between 1 and 3 times: ");

            // Check if the count of 'w' characters is between 1 and 3 (inclusive) and print the result
            Console.WriteLine(count >= 1 && count <= 3);

        }
    }
}
