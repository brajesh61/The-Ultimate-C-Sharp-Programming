using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_odd_number
{
    internal class Program
    {
        /*
         * 25. Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
         */
        static void Main(string[] args)
        {
            //int n = 100;
            for (int i = 0; i < 100; i++)
            { 
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
