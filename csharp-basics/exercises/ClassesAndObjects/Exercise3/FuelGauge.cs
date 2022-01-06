using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class FuelGauge
    {
        //fields
        private int _fuelInLiters;
        private int _tankCapacity = 70;

        //constructor
        public FuelGauge(int fuel)
        {
            _fuelInLiters = fuel;
        }

        //properties
        public int FuelInLiters
        {
            get => _fuelInLiters;
            set
            {
                if (_fuelInLiters > TankCapacity)
                {
                    _fuelInLiters = 70;
                }
                else
                {
                    _fuelInLiters = value;
                }
            }
        }

        public int TankCapacity
        {
            get {return _tankCapacity; }
        }

        //methods
        public void FuelReading()
        {
            if (FuelInLiters == 0)
                Console.WriteLine("Out of fuel!");
            else
                Console.WriteLine($"{FuelInLiters}l out of 70l.");
        }

        public void FillUp()
        {
            if (FuelInLiters < TankCapacity)
                FuelInLiters++;
            if(FuelInLiters == TankCapacity)
                Console.WriteLine("Tank is full.");
        }

        public void UseFuel()
        {
            if(FuelInLiters > 0)
                FuelInLiters--;
        }
    }
}
