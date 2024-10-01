using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_int_Array_using_funtion
{
    internal class Program
    {
        /*
         * create and initialiaw int array of number 
         * create SumOfNumbers with int return type 
         * int array param
         * funtion should return total of all numbers 
         * call in main and output the total
         * extra : check the array length
            * return -1 if array empty 
             * check return in main and output message
            * do we need to return -1, how else can we make this?
        */

        static void Main(string[] args)
        {

            int[] numbers = new int[]
            {
                1, 2, 3, 4, 6, 7, 8, 9 , 10 
            };

            int result = SumOfNumbers(numbers);
            if(result > -1)
            {
                Console.WriteLine($"The total is {result}");
            }
            else
            {
                Console.WriteLine("Can not add up an empty array!");
            }
            

            Console.ReadLine();
        }
        static int SumOfNumbers(int[] numbers)
        {
            if(numbers.Length > 0)
            {
                int total = 0;
                foreach (var number in numbers)
                {
                    total += number;
                }

                return total;
            }

            return -1;
            
        }
    }
}
