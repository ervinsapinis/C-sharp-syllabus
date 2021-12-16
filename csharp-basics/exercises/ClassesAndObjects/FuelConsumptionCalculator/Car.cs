namespace FuelConsumptionCalculator
{
    public class Car
    {
        //fields
        private double _startKilometers;// Starting odometer reading
        private double _endKilometers;// ending reading
        private double _liters;// Liters of gas used between the readings

        //constructor
        public Car(double startOdo, double endingOdo, double liters)
        {
            _startKilometers = startOdo;
            _endKilometers = endingOdo;
            _liters = liters;
        }
        public Car(double startOdo)
        {
            _startKilometers = startOdo;
            _endKilometers = _startKilometers;
            _liters = 0;
        }

        //methods
        public double CalculateConsumption()
        {
            return ConsumptionPer100Km();
        }

        private double ConsumptionPer100Km()
        {
            return (_liters * 100) / _endKilometers;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _liters = liters;
            _endKilometers += mileage;
            _startKilometers = mileage;
        }
    }
}
