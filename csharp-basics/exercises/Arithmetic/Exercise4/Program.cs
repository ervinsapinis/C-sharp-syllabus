    using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int product = 1;
            int input = 10;

            for (int i = 1; i <= input; i++)
            {
                product *= i;
            }

            Console.WriteLine(product);
        }
    }
}
