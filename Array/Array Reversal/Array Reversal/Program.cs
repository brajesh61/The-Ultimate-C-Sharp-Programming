using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Array_Reversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                3, 9, 4, 6, 7, 2, 1, 0, 5, 8, 10
            };

            Array.Reverse(numbers); //reverse print not sorting
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Array.Sort(numbers);// Low to high
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            //Print revers: Hight to low
            int[] SortedNum = new int[numbers.Length];
            int x = 0;
            for (int i = numbers.Length - 1; i >= 0;  i--)
            {
                SortedNum[x] = numbers[i];
                x++;
                    
            }

            foreach (var num2 in SortedNum)
            {
                Console.Write($"{num2} ");
            }

            
            Console.ReadLine();
        }
    }
}
