using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.Geet_the_century_of_a_year
{
    internal class Program
    {
        //54. Write a C# program to get the century of a year.
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Calculate the century
            int century = (year + 99) / 100;

            // Display the result
            Console.WriteLine($"The century for the year {year} is: {century}");
            Console.ReadLine();
        }
    }
}
