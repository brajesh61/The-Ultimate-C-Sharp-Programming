using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.Check__starts_with_word
{
    internal class Program
    {
        /*
         * 34. Write a C# program to check if a string starts with a specified word.
        Note: Suppose the sentence starts with "Hello"
        Sample Data: string1 = "Hello how are you?"
        Result: Hello.
        Sample Output:
        Input a string : Hello how are you?
        True
        */
        static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string line = Console.ReadLine();

            // Check conditions and output result based on string content
            // Check if the length of the string is less than 6 and it's equal to "Hello"
            // OR check if the string starts with "Hello" and the character at index 5 is a space (' ')

            Console.WriteLine((line.Length < 6 && line.Equals("Hello")) || (line.StartsWith("Hello") && line[5] == ' '));
        }
    }
}
