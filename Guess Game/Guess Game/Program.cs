using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            int userGuess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");

            while (userGuess != randomNumber)
            {
                Console.Write("Enter your guess: ");
               string input = Console.ReadLine();

                if (int.TryParse(input, out userGuess))
               {
                    attempts++;

                    if (userGuess < randomNumber)
                    {
                       Console.WriteLine("Too low! Try again.");
                    }
                   else if (userGuess > randomNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                    }
                }
                else
              {
                    Console.WriteLine("That's not a valid number. Please enter a number between 1 and 100.");
                }
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();

        }
    }
}
