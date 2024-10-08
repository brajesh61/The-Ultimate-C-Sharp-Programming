using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Convert__hexadecimal_to_decimal
{
    internal class Program
    {
        /*
         * 30. Write a C# program to convert a hexadecimal number to a decimal number.
            Sample Output:
            Hexadecimal number: 4B0
            Convert to-
            Decimal number: 1200
        */
        static void Main(string[] args)
        {
            // Declare a string variable 'hexval' and assign a hexadecimal value "4B0" to it
            string hexval = "4B0";

            // Display the original hexadecimal number
            Console.WriteLine("Hexadecimal number: " + hexval);

            // Convert the hexadecimal string 'hexval' to its decimal equivalent
            //int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);

            
            // Display the decimal value obtained from the hexadecimal conversion
            Console.WriteLine("Decimal number: " + decValue);

            Console.ReadLine();

        }
    }
}
