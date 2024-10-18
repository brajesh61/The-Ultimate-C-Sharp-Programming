using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.Checks_last___1st_int_equal_in_array
{
    internal class Program
    {
        /*
         * 48. Write a C# program that checks if the first element and the last element of an array of integers are equal. The array length is 1 or more.
            Test Data:
            Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
            Sample Output
            True
         */
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            Console.Write("Input integer: ");
            int SearchNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(array[0].Equals(SearchNum) && array[array.Length - 1].Equals(SearchNum));
           /*if (array[0].Equals(SearchNum) && array[array.Length - 1].Equals(SearchNum))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
           */
        }
    }
}
