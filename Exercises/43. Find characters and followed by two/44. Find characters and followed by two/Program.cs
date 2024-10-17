using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _43.Find_characters_and_followed_by_two
{
    internal class Program
    {
        /*
         * 43. Write a C# program to check if a given string starts with "w" and is immediately followed by two "ww".
            Test Data:
            Input a string : www
            Sample Output
            False
         */
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string str = Console.ReadLine();

            Console.WriteLine(str.StartsWith("ww"));
            /* var count = 0;
             for (int i = 0; i < str.Length - 1; i++)
             {
                 if (str.Substring(i).Equals("W"))
                 {
                     count++;
                 }

                 if (str.Substring(i, 2).Equals("ww"))
                 {

                     Console.WriteLine("True");
                     break;
                 }
                 else
                 {
                     Console.WriteLine("False");
                     break;
                 }
             }
             */
            // Prompt the user to input a string
            /* Console.Write("Input a string : ");

             // Read the input string and store it in the variable 'str'
             string str = Console.ReadLine();

             // Call the 'test' method with the input string and output the result
             Console.WriteLine(test(str));
         }

         // Define a method named 'test' that takes a string parameter 'str' and returns a boolean value
         public static bool test(string str)
         {
             var ctr = 0; // Initialize a counter variable 'ctr' to count occurrences of 'w'

             // Iterate through the characters of the string using a for loop
             for (var i = 0; i < str.Length - 1; i++)
             {
                 // Check if the current character is 'w'; if so, increment the counter 'ctr'
                 if (str[i].Equals('w'))
                     ctr++;

                 // Check if the substring of length 2 starting at index 'i' contains "ww" 
                 // and if the counter 'ctr' is greater than 2
                 if (str.Substring(i, 2).Equals("ww") && ctr > 2)
                     return true; // If the condition is met, return 'true'
             }

             return false; // Return 'false' if the condition is not met throughout the string

         }
         */
        }   
    }
}
