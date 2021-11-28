using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth:");
            short birthYear = short.Parse(Console.ReadLine());

            Console.WriteLine("Enter your full name:");
            string userName = Console.ReadLine();

            Console.WriteLine("My name is " + userName + " and I was born in " + birthYear);
        }
    }
}
