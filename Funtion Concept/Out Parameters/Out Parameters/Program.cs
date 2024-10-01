using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            test(out num);
            Console.WriteLine(num);

            List<String> ShopingList = new List<String>
            {
                "Milk", "Coffee"
            };
            Console.WriteLine(ShopingList.IndexOf("Coffee"));

            int position = -1;
            for (int i = 0; i < ShopingList.Count; i++)
            {
                if (ShopingList[i].ToLower().Equals("coffeee"))
                { 
                    position = i;
                }
                else
                {
                    position = -1;
                }
            }
            //Console.WriteLine(position > -1 ? "Found" : "Not found");
            Console.WriteLine(position);
            Console.ReadLine();
        }

        static bool TryPherse(String s, out int result)
        {
            result = 0;
            return true;
        }
        
        static void test(out int num)
        {
            num = 10;
        }
    }
}
