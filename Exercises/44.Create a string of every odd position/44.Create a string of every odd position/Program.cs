using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.Create_a_string_of_every_odd_position
{
    internal class Program
    {
        /*
         * 44. Write a C# program to create a string of every other character (odd position) from the first position of a given string.
            Test Data:
            Input a string : w3resource
            Sample Output
            wrsuc
         */
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result += str[i];
                i++;
            }
            Console.WriteLine("New word: " + result);
            Console.ReadLine();
        }
    }
}
