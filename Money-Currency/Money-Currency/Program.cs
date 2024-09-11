using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Currency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Currency
            Console.Write("Enter money: ");
            double money = Convert.ToDouble(Console.ReadLine());
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
