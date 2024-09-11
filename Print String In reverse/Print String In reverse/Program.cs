using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Threading;

namespace Print_String_In_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string input = Convert.ToString(Console.ReadLine());
            string name = "Brajesh";
          
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
            }
            // string empty conecpt
            if (input == string.Empty)
            {
                Console.WriteLine("Your String is empty");
            }
            // string equals conept
            else if (input.Equals(name))
            {
                
                Console.WriteLine($"Your name is {name}");
                Console.WriteLine(name);
                //System.Threading.Thread.Sleep(1000);  1000ms = 1 sec
                //Thread.Sleep(1000);
                for (int i = 0; i < input.Length; i++)
                {
                    //string interation looping
                    if (name[i].Equals('a'))
                    {

                        Console.WriteLine("True");
                        
                    }
                    else
                    {
                        Console.WriteLine("False");
                        
                    }
                    
                }
                
            }
            Console.ReadLine();
        }
    } 
}
