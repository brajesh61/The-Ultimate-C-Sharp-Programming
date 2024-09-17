using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace True_or_False
{
    //18. Write a C# program to check a pair of integers and return true if one is negative and one is positive.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Short method
            Console.WriteLine((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0));

            //Long method
            if (num1 < 0 )
            {
                if (num2 > 0)
                {
                  Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }                
               
            }
            else if (num2 < 0) 
            {
                if (num1 > 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
                
            }
            else
            {
                Console.WriteLine("False");
            }
           
            Console.ReadLine();
        }
    }
}
