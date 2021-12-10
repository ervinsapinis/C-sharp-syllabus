using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");

            string answer;
            Console.WriteLine("Roll again? Y/N");
            answer = Console.ReadLine().ToUpper();
            CheckResponse(answer);

            Random rnd = new Random();
            int dice = rnd.Next(1, 6);
            int score = 0;
            if (dice == 1)
            {
                Console.WriteLine("You rolled a 1!");
                Console.WriteLine("You got 0 points.");
            }
            else
            {
                Console.WriteLine($"You rolled a {dice}!");
                score += dice;
            }

        }

        public static int DiceRoll()
        {

        }

        public static string CheckResponse(string input)
        {
            string yes = "Y";
            string no = "N";
            bool check = input == yes || input == no;

            while (!check)
            {
                check = input == yes || input == no;
                Console.WriteLine("Invalid input. Please respond with Y or N to continue.");
                Console.WriteLine("Roll again? Y/N");
                input = Console.ReadLine().ToUpper();
            }
            return input;
        }
    }
}
