using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Tringle_using_funtions
{
    internal class Program
    {
        /*
         * Ask user for width and heigth, store them
         * create funtion to calculate the are 
         * funtion should calculate the are using : (Width * Heigth) / 2
         * call in main funtion and print out the area of tringle
         */

        static void Main(string[] args)
        {
            double width = ReadInt("Enter width: ");
            double heigth = ReadInt("Enter heigth: ");

            double result = CalArea(width, heigth);
            Console.WriteLine($"Area of tringle is {result}.");

            Console.ReadLine();
        }

        static double CalArea(double width, double heigth)
        {
            return Convert.ToDouble((width * heigth) / 2);
        }
        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
