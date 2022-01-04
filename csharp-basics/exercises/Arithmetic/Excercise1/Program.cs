using System;

namespace Excercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result = 15;
            Console.WriteLine("Enter your first integer:");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second integer:");
            var y = Int32.Parse(Console.ReadLine());
        }

        public static bool CheckIfFifteen(int x, int y)
        {
            int result = 15;
            if (x == result |
                y == result |
                x - y == result |
                y - x == result |
                x + y == result)
                return true;
            else
                return false;
        }
    }
}
