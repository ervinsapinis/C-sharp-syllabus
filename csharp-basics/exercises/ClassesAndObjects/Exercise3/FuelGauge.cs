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
            get { return _fuelInLiters; }
            set
            {
                if (_fuelInLiters > TankCapacity)
                {
                    Console.WriteLine("Tank is full.");
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
            Console.WriteLine($"{FuelInLiters}l out of 70l.");
        }

        public void FillUp()
        {
            if (FuelInLiters < TankCapacity)
                FuelInLiters++;
            else
                Console.WriteLine("Tank is full.");
        }

            public void UseFuel()
        {
            if(FuelInLiters > 0)
                FuelInLiters--;
            else
                Console.WriteLine("Out of fuel!");
        }
    }
}
