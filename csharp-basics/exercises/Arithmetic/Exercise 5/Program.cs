using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int userGuess = int.Parse(Console.ReadLine());

            Random rnd = new();
            int computerNumber = rnd.Next(1, 100);

            if (userGuess == computerNumber)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
            else if (userGuess < computerNumber)
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {computerNumber}.");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {computerNumber}.");
            }
        }
    }
}
