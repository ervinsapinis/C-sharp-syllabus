using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstWord;
            string secondWord;

            Console.WriteLine("Enter first word:");
            firstWord = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            secondWord = Console.ReadLine();

            int printerLength;
            printerLength = 30 - firstWord.Length - secondWord.Length;

            Console.WriteLine(firstWord + DotPrinter(printerLength) + secondWord);
        }

        public static string DotPrinter(int printerLength)
        {
            string output ="";
            for (int i = 0; i < printerLength; i++)
            {
                output += '.';
            }
            return output;
        }
    }
}
