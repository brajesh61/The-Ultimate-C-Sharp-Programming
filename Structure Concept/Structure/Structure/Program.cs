using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Structure
{
    class Program
    {
        
        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;

            /*public Person(string name, int age, int birthMonth)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
            }*/
        }
        static void Main(string[] args)
        {
            /*string name = "Brajesh";
            int age = 23;
            int BirthMonth = 9;

            Person person;

            person.name = "Brajesh";
            person.age = 23;
            person.birthMonth = 9;

            Console.WriteLine($"{name} - {age} - {BirthMonth}");
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");

            string newName = "";
            int newAge = 0;
            int newBirthMonth = 0;

            ReturnPerson(ref newName, ref newAge, ref newBirthMonth);
            Console.WriteLine($"{newName} - {newAge} - {newBirthMonth}");
            */

            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");

            Console.ReadLine();

        }

        /*static void ReturnPerson(ref string name, ref int age, ref int birthmonth)
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birthmonth: ");
            birthmonth = Convert.ToInt32(Console.ReadLine());
        }*/

        static Person ReturnPerson()
        {
            Console.Write("Enter your name: ");
           string name = Console.ReadLine();

            Console.Write("Enter your age: ");
           int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birthmonth: ");
           int birthmonth = Convert.ToInt32(Console.ReadLine());
            
          
            Person person;
            person.name = name;
            person.age = age;
            person.birthMonth = birthmonth;

            return person;
            
            //return new Person(name, age, birthmonth);
        }

    }
}
