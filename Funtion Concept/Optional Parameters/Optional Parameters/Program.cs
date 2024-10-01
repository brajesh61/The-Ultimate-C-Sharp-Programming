using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5);
            Console.WriteLine(result);

            int result1 = Add(500);
            Console.WriteLine(result1);

             NamePrint("Brajesh");
            

            Console.ReadLine();
        }

        static int Add(int a, int b = default)
        {
            return a + b; 
        }

        static int AddInt(int a, [Optional] int b )
        {
            return a + b;
        }

        static void NamePrint(String name = "Amrita")
        {
            Console.WriteLine($"My name is {name}.");
        }
    }
}
