using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string answer;
            Random rnd = new Random();
            int dice = rnd.Next(1, 6);
            Console.WriteLine("Welcome to Piglet!");
            int score =0;
            dice = DiceRoll(dice);
            score += dice;
            while (true)
            {
                if (dice == 1)
                {
                    Console.WriteLine("You got 0 points.");
                    break;
                }
                Console.WriteLine("Roll again? Y/N");
                answer = Console.ReadLine().ToUpper();
                CheckResponse(answer);
                if (answer == "N")
                {
                    Console.WriteLine($"You got {score} points.");
                    break;
                }
                else
                {
                    dice = DiceRoll(dice);
                    score += dice;
                }

            }

        }

        public static int DiceRoll(int dice1)
        {
            Random rnd = new Random();
            dice1 = rnd.Next(1, 6);
            Console.WriteLine($"You rolled a {dice1}!");

            return dice1;
        }

        public static void CheckResponse(string input)
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
        }
    }
}
