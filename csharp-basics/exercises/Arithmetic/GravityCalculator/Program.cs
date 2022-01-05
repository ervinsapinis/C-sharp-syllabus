
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            var earth = new EarthGravityCalculator(initialVelocity, fallingTime, initialPosition);
            Console.WriteLine(earth.ReportResult());
            Console.ReadKey();
        }
    }

    public class EarthGravityCalculator
    {
        private const double _gravity = -9.81;  // Earth's gravity in m/s^2
        private double _initialVelocity;
        private double _fallingTime;
        private double _initialPosition;

        public EarthGravityCalculator(double initialVelocity, double fallingTime, double initialPosition)
        {
            _initialVelocity = initialVelocity;
            _fallingTime = fallingTime;
            _initialPosition = initialPosition;
        }

        private double Calculate()
        {
            return 0.5 * (_gravity * Math.Pow(_fallingTime, 2)) + (_initialVelocity * _fallingTime) + _initialPosition;
        }

        public string ReportResult()
        {
            return "The object's position after " + _fallingTime + " seconds is " + Calculate() + " m.";
        }
    }
}
