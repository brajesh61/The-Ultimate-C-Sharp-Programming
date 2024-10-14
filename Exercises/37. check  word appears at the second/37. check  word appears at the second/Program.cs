using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.check__word_appears_at_the_second
{
    internal class Program
    {
        /*
         * 37. Write a C# program to check if "HP" appears at the second position in a string and return the string without "HP".
          Test Data: PHP Tutorial
            Sample Output:
            P Tutorial
         */
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            Console.WriteLine(word.Substring(1,2).Equals("HP") ? word.Remove(1,2): word);
            Console.ReadLine();
        }
    }
}
