using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_longest_word
{
    internal class Program
    {
        /*
         * . Write a C# program to find the longest word in a string.
         *    Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
         */
        static void Main(string[] args)
        {
            string i = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            
            // Split the input string into words
            string[] word = i.Split(' ');
            // Variable to store the longest word
            string longestword = "";
            // Loop through each word to find the longest
            foreach (string words in word)
            { 
                if (words.Length > longestword.Length)
                { 
                    longestword = words; 
                }
            }
            // Print the longest word & length
            Console.WriteLine("Longest Word is: " + longestword);
            Console.WriteLine("Length is: " + longestword.Length);
            Console.ReadLine();
        }
    }
}
