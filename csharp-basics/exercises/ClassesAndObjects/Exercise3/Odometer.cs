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
        private int _mileage;
        private const int MaxMileage = 999999;

        private FuelGauge _fuelGauge;

        //constructor
        public Odometer(int mileage, FuelGauge fuelGauge)
        {
            this._mileage = mileage;
            this._fuelGauge = fuelGauge;
        }

        //properties
        public int Mileage
        {
            get;
            set;
        }

        //methods
        public void ReportMileage()
        {
            Console.WriteLine($"Current mileage is {Mileage}");
        }

        public void IncrementMileage()
        {
            if (Mileage < MaxMileage)
                Mileage++;
            else
                Mileage = 0;
        }

        public void Drive()// stopped at To be able to work with a FuelGauge object. It should decrease the FuelGauge object’s current amount of fuel by 1 liter for every 10 kilometers traveled. (The car’s fuel economy is 10 kilometers per liter.)
        {

        }
    }
}
