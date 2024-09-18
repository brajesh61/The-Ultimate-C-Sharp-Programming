using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                4, 4, 5, 10, 8, 6, 3, 2, 1, 7, 0
            };

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            //sorting
            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.ReadLine();
        }
    }
}
