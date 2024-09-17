using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int num1; int num2; int num3; int num4;
           Console.Write("Enter numbers: ");
           num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter numbers: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter numbers: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter numbers: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} {num2} {num3} {num4}");

            //array concept
            int[] numbers = new int[4]; //0-3

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]} {numbers[3]}");
            

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter numbers: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for ( int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();

            int angleCount = 3;
            int[] angles = new int[angleCount];
            int angleSum = 0;
            for (int i = 0;i < angleCount; i++)
            {
                Console.Write($"Enter angle {i + 1} : ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int angle in angles)
            {
                angleSum += angle;
            }
            Console.WriteLine("Sum of angles is " + (angleSum == 180 ? "Valid" : "Invalid!"));
            Console.ReadLine();
        }
    }
}
