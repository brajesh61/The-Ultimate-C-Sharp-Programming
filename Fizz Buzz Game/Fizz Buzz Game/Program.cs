using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*/Create a for loof from 1 to X (15)
            3 & 5 = FizzBuzz
            3 = Fizz
            5 =  Buzz 
            else = number
             */
            Console.Write("Enter Number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= input; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    } 
}
