using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_logic_error
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 35;
            if(age > 18 && age < 30)
            {
                Console.WriteLine("Over 18");
            }
            else if(age > 30)
            {
                Console.WriteLine("Over 30");
            }
            else if (age > 50)
            {
                Console.WriteLine("Over 50");
            }

            Console.ReadLine();
        }
    }
}
