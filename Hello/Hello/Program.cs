using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //factorial
            //Console.WriteLine("Enter your Number:");
            //int i = Convert.ToInt32(Console.ReadLine());
            //int k = i;

            //for (int j = 1; j< 8 ; j++)
            //{
            //    k *= j;
            //}
            //Console.WriteLine(k);


            //Write a C# Sharp program to print the results of the specified operations.
            // Test data:

            //1) -1 + 4 * 6
            //2) (35 + 5) % 7
            //3) 14 + -4 * 6 / 11
            //4) 2 + 15 / 6 * 1 - 7 % 2
            /*int i = -1;
            int j = -4;
            int k = -6;
            */
            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine((35 + 7) % 7);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //QUestion
            // Write a C# Sharp program to swap two numbers.
            //Console.WriteLine("Enter Your First Number:");
            //int i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Your Second Number");
            //int j = Convert.ToInt32(Console.ReadLine());
            //int temp = i;
            //    i = j; 
            //    j = temp;
            //Console.WriteLine("after swaping: " + i);
            //Console.WriteLine("after swaping: " + j);

            // Quwstion 6. Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
            //Console.WriteLine("Enter Your First Number: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Your Second Number: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Your Third Number: ");
            //int c =  Convert.ToInt32(Console.ReadLine());
            //int d = a * b * c;
            //Console.WriteLine("Multiple of numbers: " + d);


            // Question Write a C# Sharp program that prints the multiplication table of a number as input.

            //Console.WriteLine("Enter your number that you want table for:");
            //int i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Table of " + i + " is:");
            //for (int j = 1; j <= 10; j++)
            //{
            //    int k = i * j;

            //    Console.WriteLine(k);
            //}

            //Question Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
            //Console.WriteLine("Enter Your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You look older than " + age);

            // Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
            //Console.WriteLine("Enter Number:");
            //int i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0} {0} {0} {0}", i);
            //Console.WriteLine("{0}{0}{0}{0}", i);
            ///Question Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
            //Console.WriteLine("Enter Number: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your output is: ");
            //Console.WriteLine("{0}{0}{0}", input);
            //Console.WriteLine("{0} {0}", input);
            //Console.WriteLine("{0} {0}", input);
            //Console.WriteLine("{0} {0}", input);
            //Console.WriteLine("{0}{0}{0}", input);


            //Question Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.

            //Console.WriteLine("Enter value of celcius");
            //    //Celvius to kelvin
            //   int i = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Kelvin: {0} ", i + 273.15 + "K");
            ////Kelvin to forenheit
            //Console.WriteLine("Forenheit : {0}", (i * 1.8) + 32 + "F");

            //Question  Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}

            //Console.WriteLine("Enter input");
            //int input = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("{0} {0} {0} {0}", input);
            //    Console.WriteLine("{0}{0}{0}{0}", input);
            //}

            /*/Question Write a C# program that removes a specified character from a non-empty string using the index of a character.
            Console.Write("Enter Your string: ");
            String input = Convert.ToString(Console.ReadLine());
            Console.WriteLine(input.Substring(0));
            Console.WriteLine(input.Substring(1));
            Console.WriteLine(input.Substring(2));
            Console.WriteLine(input.Substring(3));
            Console.WriteLine(input.Substring(4));
            Console.WriteLine(input.Substring(5));
            Console.WriteLine(input.Substring(6));
            Console.WriteLine(input.Substring(7));
            */

            /*/Question  Write a C# program to create a new string from a given string where the first and last characters change their positions.
            Console.Write("Enter your string: ");
            String input = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Output is: " + output);*/
            //Currency 
            double money = 10D / 3D;
            Console.WriteLine(String.Format("{0:0}", money));
            Console.WriteLine(String.Format("{0:0.0}", money));
            Console.WriteLine(String.Format("{0:0.00}", money));
            Console.WriteLine(String.Format("{0:0.000}", money));
            //based on os 
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C3"));
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("hi-IND")));
            Console.ReadLine();

}
}
}
