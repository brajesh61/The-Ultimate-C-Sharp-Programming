using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.Check_string_is_a_palindrome_or_not
{
    internal class Program
    {
        /*
         * 
         * 56. Write a C# program to check if a given string is a palindrome or not.
            Sample Example:
            For 'aaa' the output should be true
            For 'abcd' the output should be false
        */
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            Char[] reverse = str.ToCharArray();
            Array.Reverse(reverse);

            string reverseWord = new string(reverse);

            Console.WriteLine(!str.Equals("") && str == reverseWord);
        }
    }
}
