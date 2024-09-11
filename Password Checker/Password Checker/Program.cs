using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Checker
{
    internal class Program
    {

        /*
        * Ask user to enter password, and store
        * Ask user to enter password again, and store * Check if they are both contain something * If so check if they are the same
        * If they are, print "Passwords match"
        * If they are not, print "Passwords do not match" * If they are empty, print "Please enter a password."
        */
        static void Main(string[] args)
        {
            Console.Write("Enter Password: ");
            string password = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Password again: ");
            string passwordC = Convert.ToString(Console.ReadLine());
            /*if (password.Equals(passwordC) && password == string.Empty)
            {
                Console.WriteLine("Please enter a valid Paasword");
            }
            else if (passwordC.Equals(password))
            {
                Console.WriteLine("Paaswords match");
            }
            else
            {
                Console.WriteLine("Passwords do not match");
            }*/

            //Other way
            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if (passwordC.Equals(password))
                    {
                        Console.WriteLine("Passwords match.");
                    }
                    else
                    {
                        Console.WriteLine("Passwords do not match.");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a password confirmation..");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid password..");
            }

            Console.ReadLine();

        }
    }
}
