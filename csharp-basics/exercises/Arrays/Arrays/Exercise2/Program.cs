using System;
using System.Linq;

namespace Exercise2
{
    class Program
    { 
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

            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = minElement;
                minElement++;
            }

            sum = arr.Sum();

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
