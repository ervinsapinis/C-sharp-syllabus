using System;

namespace Excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 15;
            Console.WriteLine("Enter your first integer:");
            var firstInt = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second integer:");
            var secondInt = Int32.Parse(Console.ReadLine());
        }

        public static bool CheckIfIsFifteen(int firstInt; int secondInt)
        {
            if (firstInt == result |
            secondInt == result |
            firstInt - secondInt == result |
            secondInt - firstInt == result |
            firstInt + secondInt == result)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
