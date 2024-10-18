using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52.Array_containing_the_middle_elements
{
    internal class Program
    {
        /*
         * 52. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
            Test Data:
            Array1: [1, 2, 5]
            Array2: [0, 3, 8]
            Array3: [-1, 0, 2]
            New array: [2, 3, 0]
         */
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 5};
            int[] Array2 = { 0, 3, 8};
            int[] Array3 = {-1, 0, 2};

            List<int> NewArray = new List<int>();

            NewArray.Add(Array1[1]);
            NewArray.Add(Array2[1]);
            NewArray.Add(Array3[1]);

            Console.WriteLine("Array1: " + string.Join(",", Array1));
            Console.WriteLine("Array2: " + string.Join(",", Array2));
            Console.WriteLine("New array: " + string.Join(",", NewArray));
            Console.ReadLine();
        }
    }
}
