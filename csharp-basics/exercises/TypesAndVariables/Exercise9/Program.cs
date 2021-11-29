using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input distance in meters:");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine("please input hours:");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("please input minutes:");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("please input seconds:");
            int seconds = int.Parse(Console.ReadLine());

            int totalSeconds = seconds + (minutes * 60) + (hours * 3600);
            double metersPerSecond = Math.Round((double)distance / totalSeconds, 2);
            double kmPerHour = Math.Round((double)(metersPerSecond * 18) / 5, 2);
            double milesPerHour = Math.Round((double)kmPerHour / 1.609, 2);

            Console.WriteLine("Your speed in meters/second is " + metersPerSecond);
            Console.WriteLine("Your speed in km/h is " + kmPerHour);
            Console.WriteLine("Your speed in miles/h is " + milesPerHour);
        }
    }
}
