using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59.Create_a_strictly_increasing_seq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example array
            int[] array = { 1, 3, 2, 1 };

            // Check if it is possible to create a strictly increasing sequence
            bool canBeIncreasing = CanBeStrictlyIncreasing(array);

            // Output the result
            if (canBeIncreasing)
            {
                Console.WriteLine("It is possible to create a strictly increasing sequence.");
            }
            else
            {
                Console.WriteLine("It is not possible to create a strictly increasing sequence.");
            }
        }

        // Function to check if the array can be made strictly increasing
        static bool CanBeStrictlyIncreasing(int[] arr)
        {
            int count = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] <= arr[i - 1])
                {
                    count++;

                    // More than one removal is needed, so return false
                    if (count > 1)
                    {
                        return false;
                    }

                    // Check if skipping the current or previous element maintains the order
                    if (i > 1 && arr[i] <= arr[i - 2] && arr[i + 1 < arr.Length ? i + 1 : i] <= arr[i - 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
