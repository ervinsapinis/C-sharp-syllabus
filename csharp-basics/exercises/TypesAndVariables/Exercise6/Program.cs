using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input 5 natural digits");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());
            int num4 = Int32.Parse(Console.ReadLine());
            int num5 = Int32.Parse(Console.ReadLine());
            int result = num1 + num2 + num3 + num4 + num5;
            Console.WriteLine(result);

        }
    }
}
