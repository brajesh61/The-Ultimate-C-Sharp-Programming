using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.Find_the_largest_and_lowest_values
{
    internal class Program
    {
        /*
         * 39. Write a C# program to find the largest and lowest values from three integer values.
            Test Data:
            Input first integer:
            15
            Input second integer:
            25
            Input third integer:
            30
            Sample Output
            Largest of three: 30
            Lowest of three: 15
          * 
         * 
         */
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 3rd number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Find and display the largest of the three integers using Math.Max method
            Console.WriteLine("Largest number: " + Math.Max(num1, Math.Max(num2, num3)));

            // Find and display the largest of the three integers using Math.Max method
            Console.WriteLine("Smalles number: " + Math.Min(num1, Math.Min(num2, num3)));
        }
    }
}
