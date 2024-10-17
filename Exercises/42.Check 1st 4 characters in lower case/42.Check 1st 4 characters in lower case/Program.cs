using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Check_1st_4_characters_in_lower_case
{
    internal class Program
    {
        /*
     * 42. Write a C# program to create a string where the first 4 characters are in lower case. If the string is less than 4 letters, make the whole string in upper case.
        Test Data:
        Input a string: w3r
        Sample Output
        W3R
     */
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string str = Console.ReadLine();

            if (str.Length < 4 )
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                Console.WriteLine(str.Substring(0,4).ToLower() + str.Substring(4, str.Length - 4));
            }
            Console.ReadLine();
        }
    }
}
