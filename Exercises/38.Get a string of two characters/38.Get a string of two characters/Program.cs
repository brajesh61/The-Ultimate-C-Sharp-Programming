using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.Get_a_string_of_two_characters
{
    internal class Program
    {
        /*
         * 38. Write a C# program to get a string of two characters from a given string. The first and second characters of the given string must be "P" and "H", so PHP will be "PH".
            Test Data: PHP
            Sample Output:
            PH
         * 
         */
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string word = Console.ReadLine();
            var result = "";
            if (word[0] == 'P')
            {
                result += word[0];
            }
            if (word[1] == 'H')
            {
                result += word[1];
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
