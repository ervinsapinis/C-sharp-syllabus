using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Piglet
    {
        public static void Game()
        {
            string answer;
            Random rnd = new Random();
            int dice = rnd.Next(1, 6);
            int score = 0;
            Console.WriteLine("Welcome to Piglet!");
            if (dice == 1)
            {
                Console.WriteLine("You rolled a 1!");
                Console.WriteLine("You got 0 points.");
            }
            else
            {
                Console.WriteLine($"You rolled a {dice}!");
                score += dice;
                dice = rnd.Next(1, 6);
            }

            while (dice != 1)
            {
                Console.WriteLine("Roll again? Y/N");
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    int dice1 = rnd.Next(1, 6);
                    if (dice1 == 1)
                    {
                        Console.WriteLine("You rolled a 1!");
                        Console.WriteLine("You got 0 points.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You rolled a {dice1}!");
                        score += dice1;
                        dice1 = rnd.Next(1, 6);

                    }
                }
                else
                {
                    Console.WriteLine($"You got {score} points.");
                    break;
                }
            }
        }
    }
}
