using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class FizzBuzz
    {
        public static void Game()
        {
            string input;
            int inputInt;
            bool isInt;

            Console.WriteLine("Max value?");
            input = Console.ReadLine();
            isInt = int.TryParse(input, out inputInt);

            while (!isInt)
            {
                Console.WriteLine("Please input an integer.");
                input = Console.ReadLine();
                isInt = int.TryParse(input, out inputInt);
            }

            for (int i = 1; i <= inputInt; i++)
            {
                if (i % 20 == 0 && i % 5 == 0)
                {
                    Buzz();
                    Console.WriteLine();
                }
                else if (i % 5 == 0 && i % 3 == 0)
                {
                    FizzAndBuzz();
                }
                else if (i % 5 == 0)
                {
                    Buzz();
                }
                else if (i % 3 == 0)
                {
                    Fizz();
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }

        static void Fizz()
        {
            Console.Write("Fizz ");
        }

        static void Buzz()
        {
            Console.Write("Buzz ");
        }
        static void FizzAndBuzz()
        {
            Console.Write("FizzBuzz ");
        }
    }
    
}
