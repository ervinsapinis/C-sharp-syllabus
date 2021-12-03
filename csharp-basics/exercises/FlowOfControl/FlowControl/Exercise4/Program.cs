using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number for a day: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput <= 6 && userInput >= 0)
            {
                if (userInput == 0)
                {
                    Console.WriteLine("Sunday");
                }
                if (userInput == 1)
                {
                    Console.WriteLine("Monday");
                }
                if (userInput == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                if (userInput == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                if (userInput == 4)
                {
                    Console.WriteLine("Thursday");
                }
                if (userInput == 5)
                {
                    Console.WriteLine("Saturday");
                }
                if (userInput == 6)
                {
                    Console.WriteLine("Sunday");
                }
            }
            else
            {
                Console.WriteLine("Not a valid day");
            }
        }
    }
}
