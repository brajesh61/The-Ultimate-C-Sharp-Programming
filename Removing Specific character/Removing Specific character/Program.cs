using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removing_Specific_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question Write a C# program that removes a specified character from a non-empty string using the index of a character.
            Console.Write("Enter Your string: ");
            String input = Convert.ToString(Console.ReadLine());
            Console.WriteLine(input.Substring(0));
            Console.WriteLine(input.Substring(1));
            Console.WriteLine(input.Substring(2));
            Console.WriteLine(input.Substring(3));
            Console.WriteLine(input.Substring(4));
            Console.WriteLine(input.Substring(5));
            Console.WriteLine(input.Substring(6));
            Console.WriteLine(input.Substring(7));
            Console.ReadLine(); 
        }
    }
}
