using System;

namespace Excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            var num = Int32.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            };
            Console.WriteLine("Bye!");
        }
    }
}
