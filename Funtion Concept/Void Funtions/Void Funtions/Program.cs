using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Funtions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            CreateAndPrintArray();
            Console.ReadLine();
        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my program!");
        }
    }
}
