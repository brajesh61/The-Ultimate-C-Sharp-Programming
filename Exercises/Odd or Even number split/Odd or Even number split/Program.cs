using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even_number_split
{
    internal class Program
    {
        /* 
         * Create two list with integer data type , one for even number, one for odd number
         * loop form 0-20
            * if number is even, add to even list 
            * if number is odd, add to odd list 
         * print even list
         * print odd list
         */

        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            Console.WriteLine("Enter range:");
            Console.Write("Start: ");
            int start  = Convert.ToInt32(Console.ReadLine());
            Console.Write("End: ");
            int end = Convert.ToInt32(Console.ReadLine());
            
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }
            Console.WriteLine("Prnting even numbers:");

            foreach (var item in even)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(Environment.NewLine + "Printing odd numbers: ");
           // Console.WriteLine("Printing odd numbers:");

            foreach (var item in odd)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
        }
    }
}
