using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_String
{
    internal class Program
    {
        //Write a C# program to create a new string from a given string where the first and last characters change their positions. 
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string  input = Convert.ToString(Console.ReadLine());
            Console.WriteLine(input.Substring(input.Length - 1) + input.Substring(1) + input.Substring(0,1));
           
            Console.ReadLine();
        }
    }
}
