using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Create_a_string_of_four_copies
{
    internal class Program
    {
        /*
         * 32. Write a C# program to create a string of four copies, taking the last four characters from a given string. If the given string is less than 4, return the original one.
            Sample Output:
            Input a string : The quick brown fox jumps over the lazy dog.
            dog.dog.dog.dog.
        */

        static void Main(string[] args)
        {

            // Display a message asking the user to input a string
            Console.Write("Input a string : ");

            // Read user input and store it in the 'str' variable
            string str = Console.ReadLine();

            // Check if the length of the input string is greater than 4
            if (str.Length > 4)
            {
                // If the length is less than 4, concatenate the input string thrice
                // If the length is greater than or equal to 4, concatenate the last 4 characters of the input string four times
                //Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(str.Substring(str.Length - 4));
                }
            }            
            else
            {
                Console.WriteLine("Oh no Length is less than 4!" + $"\nOriginal string: {str}");
            }
             Console.ReadLine();
        }
    }
}

