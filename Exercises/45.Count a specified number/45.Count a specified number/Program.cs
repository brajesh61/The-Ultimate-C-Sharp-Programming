using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.Count_a_specified_number
{
    internal class Program
    {
        /*
         * 45. Write a C# program to count a specified number in a given array of integers.
            Test Data:
            Input an integer: 5
            Sample Output
            Number of 5 present in the said array: 2
         */
        static void Main(string[] args)
        {
            Console.Write("Input an integer: ");
            int SearchNum = Convert.ToInt32(Console.ReadLine());

            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

            Console.WriteLine("Number of " + SearchNum + " present in the array: " + nums.Count(n => n == SearchNum));

            Console.ReadLine();
        }
    }
}
