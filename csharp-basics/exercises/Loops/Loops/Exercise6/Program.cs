using System;
using System.Threading.Channels;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int inputInt;
            bool isBool;

            Console.WriteLine("Max value?");
            input = Console.ReadLine();
            isBool = int.TryParse(input, out inputInt);

            while (!isBool)
            {
                Console.WriteLine("Please input an integer.");
                input = Console.ReadLine();
                isBool = int.TryParse(input, out inputInt);
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
                    FizzBuzz();
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
                    Console.Write(i+" ");
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
        static void FizzBuzz()
        {
            Console.Write("FizzBuzz ");
        }
    }
}
