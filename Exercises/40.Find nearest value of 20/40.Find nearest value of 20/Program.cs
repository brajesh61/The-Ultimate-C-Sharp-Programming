using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Find_nearest_value_of_20
{
    internal class Program
    {
        /*
         * 40. Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.
            Test Data:
            Input first integer:
            15
            Input second integer:
            12
            Sample Output
            15
         */
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            
            var value1 = Math.Abs(num1 - 20);
            var value2 = Math.Abs(num2 - 20);

            Console.WriteLine(value1 == value2 ? 0 : value1 < value2 ? num1 : num2);

            /*
            if (num1 == num2)
            {
                Console.WriteLine("0");
            }
            else
            {
                //Console.WriteLine(value1 < value2 ? num1 : num2);
                if (value1 < value2)
                {
                    Console.WriteLine("Nearest number: " + num1);
                }
                else
                {
                    Console.WriteLine("Nearest number: " + num2);
                }
            }
            */
            Console.ReadLine();
        }
    }
}
