using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Greater_and_equal
{
    internal class Program
    {
        /*
         * 35. Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200.
         * Sample Output:
            Input a first number(<100): 75
            Input a second number(>100): 250
            True
         */
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 < 100 && num2 > 200);
        }
    }
}
