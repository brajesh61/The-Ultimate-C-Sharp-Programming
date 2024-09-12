using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specified_character_from_a_non_empty
{
    internal class Program
    {
        //Write a C# program that removes a specified character from a non-empty string using the index of a character.
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string input = Convert.ToString(Console.ReadLine());

            //Reverse
            for (int i = input.Length; i >= 0; i--)
            {
                Console.WriteLine(input.Substring(i));

            }
            Console.WriteLine();
            for (int i = 0; i < input.Length;  i++)
            {
                Console.WriteLine(input.Substring(i));

            }

            Console.ReadLine();
        }
    }
}
