using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
            };
            double average = sum / upperBound;

            Console.WriteLine(sum);
            Console.WriteLine(average);
        }
    }
}
