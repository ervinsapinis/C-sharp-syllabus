using System;

namespace Excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your integer");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckOddEven.CheckValue(x));
            Console.WriteLine(CheckOddEven.ByeMessage());
        }
    }
}
