using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a sentence:");
            string input = Console.ReadLine();
            byte counter = 0;
            foreach(char c in input)
            {
                if (Char.IsUpper(c))
                {
                    counter++;
                }
            };
            Console.WriteLine(counter);
            
        }
    }
}
