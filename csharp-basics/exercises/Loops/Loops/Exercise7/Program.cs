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
            int score = 0;
            
            Console.WriteLine("Welcome to Piglet!");
            DiceRoll(dice, score);
            while (true)
            {
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
                    int dice1 = rnd.Next(1, 6);
                    DiceRoll(dice1, score);
                }

            }

        }

        public static void DiceRoll(int dice1, int score1)
        {
            Random rnd = new Random();
            if (dice1 == 1)
            {
                Console.WriteLine("You rolled a 1!");
                Console.WriteLine("You got 0 points.");
            }
            else
            {
                Console.WriteLine($"You rolled a {dice1}!");
                score1 += dice1;
                dice1 = rnd.Next(1, 6);
            }
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
