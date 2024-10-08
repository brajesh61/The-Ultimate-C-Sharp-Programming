using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Reverse_the_words
{
    internal class Program
    {
        /*
         * 28. Write a C# program to reverse the words of a sentence.
            Sample Output:
            Original String: Display the pattern like pyramid using the alphabet.
            Reverse String: alphabet. the using pyramid like pattern the Display
        */
        static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string line = Console.ReadLine();
            /*
            string result = ""; // Initializing an empty string to store the reversed words
            List<string> wordsList = new List<string>(); // Creating a list to store reversed strings

            string[] words = line.Split(new[] { " " }, StringSplitOptions.None); // Splitting the string into individual words

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " "; // Building the reversed string by adding words in reverse order
            }

            wordsList.Add(result); // Adding the reversed string to the list

            // Loop to print the reversed string from the list
            foreach (String s in wordsList)
            {
                Console.WriteLine("\nReverse String: " + s); // Displaying the reversed string
            }
            */
            
            // Split the sentence into words
            string[] words = line.Split(' ');

            // Reverse the words array
            Array.Reverse(words);
            // Join the reversed words back into a sentence
            string reversedSentence = string.Join(" ",words);

            // Output the reversed sentence
            Console.Write($"Reversed sentence: {reversedSentence}");
           
            Console.ReadLine();
        }
    }
}
