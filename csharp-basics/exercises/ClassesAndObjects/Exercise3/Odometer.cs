using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Odometer
    {
        //fields
        private int _startingMileage;
        private int _mileage;
        private int _fuelEconomy = 10;
        private const int MaxMileage = 999999;
        private FuelGauge _fuelGauge;

        //constructor
        public Odometer(int mileage, FuelGauge fuelGauge)
        {
            _startingMileage = mileage;
            _mileage = mileage;
            _fuelGauge = fuelGauge;
        }

        //properties
        public int Mileage
        {
            get => _mileage;
            set => _mileage = value;
        }

        //methods
        public void ReportMileage()
        {
            Console.WriteLine($"Current mileage is {Mileage}");
        }

        public void Drive()
        {
            int kmDriven = _mileage - _startingMileage;

            if (Mileage < MaxMileage)
                Mileage++;
            else
                Mileage = 0;

            if(kmDriven % _fuelEconomy == 0)
                _fuelGauge.UseFuel();
        }
    }
}
