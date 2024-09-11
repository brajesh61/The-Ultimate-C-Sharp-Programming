using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Brajesh";
            int age = 22;
            Console.WriteLine("Your name is " + name + " and your age is " + age); //simple
            Console.WriteLine($"Your name is {name} and your age is {age}"); //interpolation : easy & best way
            Console.WriteLine("Your name is {0} and your age is {1}", name, age);
            string output = string.Concat("Your name is ", name, " and your age is ", age); //string concatenation
            Console.WriteLine(output);
            Console.WriteLine(string.Concat("Your name is ", name, " and your age is ", age));

            //other way
            string[] names = new string[] { "Brajesh", " Amrita", " Yadav" };
            Console.WriteLine(string.Concat(names));
            
            Console.ReadLine();


        }
    }
}
