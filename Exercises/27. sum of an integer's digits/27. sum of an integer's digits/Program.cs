using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.sum_of_an_integer_s_digits
{
    internal class Program
    {
        /*
         * 27. Write a C# program and compute the sum of an integer's digits.
            Sample Output:
            Input a number(integer): 12
            Sum of the digits of the said integer: 3
        */
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
             int sum = 0;
            /*while (num != 0)
            {
                Console.WriteLine(num % 10);
                Console.WriteLine(num /= 10);
            }
            */
            while (num != 0)
            {
                sum += num % 10; // Adding the last digit of 'num' to the 'sum' variable
                num /= 10; // Removing the last digit from 'num'
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
            
            Console.ReadLine();
        }
    }
}
