using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool PlayAgain = true;
            int guess;
            int attempts;
            int number;
            string response;

            while (PlayAgain)
            {
                guess = 0;
                attempts = 0;
                number = random.Next(1, 11);
                response = "";
                while (number != guess)
                {
                    Console.Write("Guess a number between 1 and 10: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number)
                    {
                        Console.WriteLine("Try Smaller Number");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"Try Bigger Number");
                    }
                    attempts++;
                }
                Console.WriteLine($"Correct! the Number is: {number}");
                Console.WriteLine($"Number of attempts: {attempts}");

                Console.Write("Would you like to play again (Y/N): ");
                response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    PlayAgain = true;
                }
                else if (response == "n")
                {
                    PlayAgain = false;
                }
                else
                {
                    Console.WriteLine("Please type 'Y' for Yes and 'N' for No");
                }
            }
            Console.WriteLine("Thanks for playing");
        }
    }
}
