using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_error_message
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

                    Console.WriteLine(num);
                    loop = false;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
}
