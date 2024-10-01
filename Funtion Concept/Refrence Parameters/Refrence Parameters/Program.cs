using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrence_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num = 10;
            string name = "Brajesh";
            Assign(ref num, ref name);
            Console.WriteLine(num);
            Console.WriteLine(name);
            */

            string name = string.Empty;

            Console.Write("Enter your new name: ");
            string Newname = Console.ReadLine();

           if(ChangeName(ref name, Newname))
           {
                
                Console.Write($"Your new name is {name}.");

           }
           else
           {
                Console.Write($"Your new name can not be empty.");

           }


            Console.ReadLine();
        }

        static bool ChangeName(ref string name, string Newname)
        {
            if (!string.IsNullOrEmpty(Newname))
            {
                name = Newname;
                return true;
            }
            return false;
        }


        static void Assign(ref int num, ref string name)
        {
            num = 20;
            name = string.Empty;//"Kumar";
        }
    }
}

