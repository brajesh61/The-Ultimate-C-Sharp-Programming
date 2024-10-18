using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Check_array_contains_an_odd_number
{
    internal class Program
    {
        /*
         * 53. Write a C# program to check if an array contains an odd number.
            Test Data:
            Original array: [2, 4, 7, 8, 6]
            Check if an array contains an odd number? True
         */
        static void Main(string[] args)
        {
            int[] ints = { 2, 4, 10, 8, 6 };

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 != 0)
                { 
                 Console.WriteLine(ints[i] % 2 != 0);
                    break;
                }
                
            }
            
            Console.ReadLine();
        }
    }
}
