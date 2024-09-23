using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dictionary<int, string> names = new Dictionary<int, string>
             {
                 //KeyValuePair
                 { 1, "Brajesh"},
                 { 2, "Kumar"},
                 { 3, "Amrita"},
                 { 4, "Singh"},
             };

             //print using for loop
             for (int i = 0; i < names.Count; i++)
             {
                 KeyValuePair<int, string> pair = names.ElementAt(i);
                 Console.WriteLine($"{pair.Key} - {pair.Value}");
             }
             Console.WriteLine();

             //print using foreach loop(easy)
             //foreach(KeyValuePair<int, string> item in names)
             foreach(var item in names)
             {
                 Console.WriteLine($"{item.Key} - {item.Value}");

             }
             */
            Dictionary<String, String> teachers = new Dictionary<String, String>
            {
                {"Math", "Brajesh"},
                {"Hindi", "Amrita"}
            
            };
            Console.WriteLine(teachers["Math"]);

            if(teachers.TryGetValue("Math", out String teacher))
            {
                Console.WriteLine(teacher);
                teachers["Math"] = "Yadav";
            }
            else
            {
                Console.WriteLine("Math teacher is not found!");
            }
            if(teachers.ContainsKey("Math"))
            {
               teachers.Remove("Math");
            }
           /*/ if (teachers.ContainsValue("Yadav")) 
            {
                teachers.Remove("Math");
            }
            */  
            //foreach(var item in teacher) //print charactor wise 
             //foreach(String key in teachers.Keys)//Print key
            foreach (var item in teachers)
            {

            Console.WriteLine($"{item.Key} - {item.Value}"); 
            }
        


        }
    }
}
