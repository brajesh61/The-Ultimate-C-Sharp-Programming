using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Number_is__multiple_of_3_or_7
{
    internal class Program
    {
        /*
         * 33. Write a C# program to check if a given positive number is a multiple of 3 or 7.
            Sample Output:
            Input first integer:
            15
            True
        */
        static void Main(string[] args)
        {
            Console.Write("Enter natural number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 3  == 0  || num % 7 == 0)
            if (num > 0 ) 
            {
                //Console.WriteLine(true);
                // Print the result of the logical OR operation between the conditions (divisible by 3 or 7)
                Console.WriteLine(num % 3 == 0 || num % 7 == 0);
            }
            Console.ReadLine();
        }
    }
}
