using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.Check_integers_change
{
    internal class Program
    {
        /*
        36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
        Sample Output:
        Input a first number: -5
        Input a second number: 8
        True
            */
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 >= -10 & num1 <= 10 || num2 >= -10 && num2 <= 10);
        }
    }
}
