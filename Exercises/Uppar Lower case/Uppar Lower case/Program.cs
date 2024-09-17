using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppar_Lower_case
{
    internal class Program
    {
        /*/23. Write a C# program to convert a given string into lowercase.
        Sample Output:
         write a c# sharp program to display the following pattern using the alphabet
        */
        static void Main(string[] args)
        {
            //Console.Write("Enter string: ");
            //string input = Convert.ToString(Console.ReadLine());
            string input = "write a c# sharp program to display the following pattern using the alphabet.";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());
            Console.WriteLine(char.ToUpper(input[0]) + input.Substring(1).ToLower());
            Console.ReadLine();

        }
    }
}
