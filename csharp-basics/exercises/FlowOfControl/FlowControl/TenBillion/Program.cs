using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();

            int digits = input.Length;

            if (input[0] == '-')
            {
                digits--;
            }

            long n = long.Parse(input);
            
            if (n < 0)
            {
                n *= -1;
            }

            // todo - check if Long
            if (n >= 10000000000)
            {
                Console.WriteLine("Number is greater or equals 10,000,000,000!");
            }
            else
            {
                Console.WriteLine("Number of digits in the number: " + digits);
            }
        }
    }
}
