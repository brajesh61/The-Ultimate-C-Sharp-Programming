using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Funtion
{
    internal class Program
    {
        //static string name = "Brajesh";
        static void Main(string[] args)
        {
           // Console.Title = $"{ReturnName()} - {ReturnAge()}"; //bewlo is same
            Console.Title = ReturnNameAge();
            PrintIntroduction();
            ReturnNameAge();
            //ReturnName();

            //Read number from console
            Console.Write("Enter array lemgth: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] number = new int[num];
            for (int i = 0; i < num; i++)
            {
                number[i] = ReadFromConsole();
            }

            foreach (int item in number)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            //Add funtion 
            Console.WriteLine(Add());

            Console.ReadLine();
        }
        static int ReadFromConsole()
        {
            Console.Write("Enter number : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Add()
        {
            return 5 + 5;
        }

        static string ReturnName()
        {
            //return name;
            return "Brajesh";
        }

        static string ReturnAge()
        {
            return "23";
        }

        static void PrintIntroduction()
        {
            //Console.WriteLine(ReturnName());
            //string name = ReturnName();
            //Console.WriteLine(name);
            //string output = $"Hello my name is {ReturnName()} and my age is {ReturnAge()}";
            //Console.WriteLine(output);
            Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}");
        }
        
        static String ReturnNameAge()
        {
            return $"{ReturnName()} - {ReturnAge()}";
        }
        
    }
}
