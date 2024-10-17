using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.Searching_number_present_or_not
{
    internal class Program
    {
        /*
         * 46. Write a C# program to check if a number appears as the first or last element of an array of integers. The array length is 1 or more.
            Test Data:
            Input an integer: 25
            Sample Output
            False
         */
        static void Main(string[] args)
        {
            Console.Write("Input integer: ");
            int SearchNum = Convert.ToInt32(Console.ReadLine());

            // Define an array of integers 'nums' with pre-defined values
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

            // Check if the first element of the array 'nums' is equal to 'x'
            // OR if the last element of the array 'nums' is equal to 'x'
            // Print the result of the logical OR operation between these conditions
            //Console.WriteLine(nums[0] == SearchNum || nums[nums.Length - 1] == SearchNum);

            //Searching number present or not
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == SearchNum)
                {
                    Console.WriteLine(nums[i] == SearchNum);
                    break;
                }
                if(!nums[i].Equals(SearchNum))
                {
                    Console.WriteLine(nums[i].Equals(SearchNum));
                    break;
                }
            }
        }
    }
}
