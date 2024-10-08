using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Find_the_size_in_bytes
{
    internal class Program
    {
        //29. Write a C# program to find the size of a specified file in bytes.

        static void Main(string[] args)
        {
            // Creating a FileInfo object representing a file at the specified path
            FileInfo f = new FileInfo("C:\\Users\\Kumar\\Downloads\\Bhagavad-gita-hindi.pdf");

            // Displaying the size of the file in bytes using FileInfo's Length property
            Console.WriteLine("\nSize of a file: " + f.Length + " bytes");
            Console.ReadLine();
        }
    }
}
