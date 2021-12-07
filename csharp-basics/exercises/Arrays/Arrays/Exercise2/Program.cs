using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {       
        // TODO: Write a C# program to sum values of an array.
        // Array values are starting from min (including) till max (including) number. 
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());
            int arrLength = maxNumber - minNumber;
            int[] arr = new int[arrLength];
            int minElement = minNumber;

            for (int i = 0; i < arrLength; i++) // es nesaprotu, kādēļ liekot i <= arrLength man met errorus arā pie palaišanas. tādēļ arī summa tāda.
            {
                arr[i] = minElement;
                minElement++;
            }

            sum = arr.Sum() + maxNumber;

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
