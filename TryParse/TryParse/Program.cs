using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter Number: ");
            string input = Console.ReadLine();
            int result = 0;
            //int.TryParse(input, out result); //TryParse try to convert string into int32.give output 0. 0 means failed to convert. not giving error. not need to use Convert.ToIn32 funtion.
            //Console.WriteLine(result);

            //for example 
            bool success = int.TryParse(input, out result);
            if (success)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to Convert");
            }
            */

            //Using while loop
            bool success = true;
            while (success)
            {

                Console.Write("Enter Number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    success = false;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Failed to Convert");
                }
            }
        }
    }
}