using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Prime_numbers
{
    internal class Program
    {
        /*
         * 26. Write a C# program to compute the sum of the first 500 prime numbers.
         */

        // Function to check if a number is prime
        static bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static void Main()
        {
            Console.WriteLine("Define the Prime number range");
            Console.Write("Start from : ");
            // Define the range
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("End: ");
            int end = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine($"Prime numbers between {start} and {end}: ");

            // Loop through the range and check for prime numbers
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"The sum of the prime numbers bewteen {start} and {end} is: " + sum);
            //Console.ReadLine();


            Console.WriteLine(); // Print a new line after the prime numbers
            int count = 0; // Count of prime numbers found
            int sum1 = 0;   // Sum of prime numbers
            int number1 = 2; // Starting from the first prime number

            while (count < 500) // Loop until we find the first 500 primes
            {
                if (IsPrime(number1))
                {
                    sum1 += number1;
                    count++;
                }
                number1++;
            }

            // Print the sum of the first 500 prime numbers
            Console.WriteLine($"The sum of the 1st 500 prime numbers is: " + sum1);
        }
    }
    
}
