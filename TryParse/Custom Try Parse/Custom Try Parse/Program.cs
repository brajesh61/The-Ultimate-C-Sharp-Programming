using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Try_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*bool success = false;
            try
            {
                Console.Write("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yey " + num);
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oh no!! " + ex.Message);
               // Console.WriteLine(ex.Message);
            }
            //Console.WriteLine(success ? "Yey" : "Oh no");
            Console.ReadLine();
            */
            
            Console.Write("Enter number: ");
            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Yey " + result);
            }
            else
            {
                Console.WriteLine("Oh no");
            } 
        }

        static bool TryParse(string input, out int result)
        {
            result = -1;
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
