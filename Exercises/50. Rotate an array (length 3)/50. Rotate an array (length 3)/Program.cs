using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.Rotate_an_array__length_3_
{
    internal class Program
    {
        /*
         * 50. Write a C# program to rotate an array (length 3) of integers in the left direction.
            Test Data:
            Array1: [1, 2, 8]
            After rotating array becomes: [2, 8, 1]
         */
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 8 };

            var temp = Array[0];
            for (int i = 0; i < Array.Length - 1; i++)
            {
                Array[i] = Array[i + 1];  // // Shift each element one place to the left
            }
            Array[Array.Length - 1] = temp;  /// Assign the value of 'temp' to the last element of 'array'
            Console.WriteLine(string.Join(",",Array));
        }
    }
}
