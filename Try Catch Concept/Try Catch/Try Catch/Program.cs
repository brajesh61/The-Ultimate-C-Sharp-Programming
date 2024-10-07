using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                try
                {
                    Console.Write("Enter number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"number is {num}");

                    //Console.ReadLine();
                    loop = false;
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Please enter number less than 2 billion");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please enter number only!");
                }

                catch (Exception) //catch everything 
                {
                    Console.WriteLine("Something went wrong!");
                }

            }
        }
    }
}
