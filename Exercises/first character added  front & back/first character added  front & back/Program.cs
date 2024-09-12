using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_character_added__front___back
{
    internal class Program
    {
        //Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
        static void Main(string[] args)
        {
            Console.Write("Enter messagee: ");
            String input = Convert.ToString(Console.ReadLine());
            Console.WriteLine(input.Substring(0,1) + input + "." + input.Substring(0,1));
            Console.ReadLine();
        }
    }
}
