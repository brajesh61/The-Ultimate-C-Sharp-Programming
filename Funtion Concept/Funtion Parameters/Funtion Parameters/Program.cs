using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funtion_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(50, 50));

            int num = ReadInt("Enter a number: ");
            //int num = ReadInt("Number");
            Console.WriteLine(num);

            int num1 = ReadInt("Enter angle: ");
           // int num1 = ReadInt("angle");
                Console.WriteLine(num1);

            // 
            int FirstNum = ReadInt("Enter first number: ");
            int SecondNum = ReadInt("Enter Second number: ");
            int result = Add(FirstNum, SecondNum);
            Console.WriteLine($"Sum of numbers = {result}");


            String name = ReadString("Enter your name: ");
            int age = ReadInt("Enter your age: ");
            string details = UserDetails(name,age);
            Console.WriteLine(details);

            Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            return a + b;   
        }

        static int ReadInt(string message)
        {
            Console.Write($"{message}");
            //Console.Write($"Enter a {message} : ");
            return Convert.ToInt32( Console.ReadLine() );
        }

        static string ReadString(string message)
        {
            Console.Write($"{message}");
            return Console.ReadLine();
        }

        static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}.";
        }
    }
}
