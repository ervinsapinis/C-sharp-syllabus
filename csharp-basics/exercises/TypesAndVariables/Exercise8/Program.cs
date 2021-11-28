using System;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the desired amount of minutes:");
            int minutes = int.Parse(Console.ReadLine());
            int years = minutes / 525600;
            int minutesLeftOver = minutes % 525600;
            int days = minutesLeftOver / 1440;
            Console.WriteLine(minutes + " are " + years + " years and about " + days + " days");
        }
    }
}
