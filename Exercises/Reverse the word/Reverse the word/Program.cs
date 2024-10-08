using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_the_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to enter a word
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            // Convert the word into a character array, reverse it, and then convert back to a string
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            string reversedWord = new string(wordArray);

            // Output the reversed word
            Console.WriteLine("Reversed word: " + reversedWord);
        }
    }
}
