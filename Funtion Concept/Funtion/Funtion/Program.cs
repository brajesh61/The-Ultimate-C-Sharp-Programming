using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funtion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers();  //printing accordingly 
            WelcomeMessage();
            Console.ReadLine();
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my program!!");
        }

        static void Numbers()
        {
            Console.WriteLine("123");
        }
    }
}
