using System;
using System.Threading.Channels;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelGauge golfGauge = new FuelGauge(50);
            Odometer golfOdometer = new Odometer(999800, golfGauge);

            Console.WriteLine("Filling up the car...");
            for (int i = golfGauge.FuelInLiters; i < golfGauge.TankCapacity; i++)
            {
                golfGauge.FillUp();
                Console.WriteLine($"{golfGauge.FuelInLiters} out of 70...");
            }

            Console.WriteLine();
            Console.WriteLine("Starting up...");
            Console.WriteLine();

            while (golfGauge.FuelInLiters > 0)
            {
                golfOdometer.Drive();
                golfOdometer.ReportMileage();
                golfGauge.FuelReading();
                Console.WriteLine();
            }
        }
    }
}
