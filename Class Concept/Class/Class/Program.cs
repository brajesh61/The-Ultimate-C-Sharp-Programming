using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;
            

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
                
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Person person = new Person(name, age);
                // Console.WriteLine($"Name: {person.name}\nAge: {person.age}");

                if (!String.IsNullOrEmpty(person.name))
                {
                    Console.WriteLine($"Name: {person.name}");
                }
                

                if (person.age > -1)
                {
                    Console.WriteLine($"Age: {person.age}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
