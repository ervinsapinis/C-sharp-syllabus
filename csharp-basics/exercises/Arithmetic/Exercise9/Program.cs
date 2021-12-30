using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your height in cm:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your weight in kg:");
            int weight = int.Parse(Console.ReadLine());

            double heightInInches = height / 2.54;
            double weightInPounds = weight * 2.205;

            double bodyMassIndex = Math.Floor(weightInPounds * 703 / Math.Pow(heightInInches, 2));

            if (bodyMassIndex > 25)
            {
                Console.WriteLine($"Your BMI is {bodyMassIndex}, which is considered to be overweight.");
            }
            else if (bodyMassIndex < 18.5)
            {
                Console.WriteLine($"Your BMI is under {bodyMassIndex}, which is considered to be underweight.");
            }
            else
            {
                Console.WriteLine($"Your BMI is {bodyMassIndex}, which is considered to be optimal.");
            }
        }
    }
}
