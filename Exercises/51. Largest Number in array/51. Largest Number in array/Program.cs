using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51.Largest_Number_in_array
{
    internal class Program
    {
        /*
         * 51. Write a C# program to get the largest value between the first and last element of an array (length 3) of integers.
        Test Data:
        Array1: [1, 2, 5, 7, 8]
        Highest value between first and last values of the said array: 8
         */
        static void Main(string[] args)
        {
           int[] Array = { 1, 2, 15, 7, 8};

            Console.WriteLine("Largest Number: " + Array.Max());
            Console.ReadLine();

            /*/Highest value between first and last values of the said array
            var HighetNum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > Array[0])
                {
                    HighetNum = Array[i];
                }
            }
            Console.WriteLine("Largest Number: " + HighetNum);
            */
        }
    }
}
