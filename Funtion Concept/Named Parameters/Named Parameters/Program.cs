using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* string name = "Brajesh";
            int age = 22;
            string Address = "Deori";

            PrintDetails(name, age, Address);
            */
            string nameInput = "Brajesh";
            int ageInput = 22;
            string AddressInput = "Deori";

            PrintDetails(age:ageInput, name:nameInput, Address:AddressInput);
            
            Console.ReadLine(); 
        }

        /*static void PrintDetails(string name, int age, string Address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {Address}");
        }
        */
        static void PrintDetails(string name, int age, string Address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}

