using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_equal_multiple
{
    //19. Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter your 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("SumTriple: " + (a + b) * 3);
            }
            else
            {
                Console.WriteLine("sum of number : " + (a + b));  
            }

           */// 20.Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than the second number.
            Console.Write("Enter 1st number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 1st number: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (c > d)
            {
                Console.WriteLine("Double of absolute value: " + (c - d) * 2);
            }
            else
            {
                Console.WriteLine("absolute value : " + (d - c));
            }
        }
    }
}
