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
            this._startKilometers = startOdo;
            this._endKilometers = endingOdo;
            this._liters = liters;
        }

        //methods
        public double CalculateConsumption()
        {
            return ConsumptionPer100Km();
        }

        private double ConsumptionPer100Km()
        {
            return (_liters * 100) / (_endKilometers - _startKilometers);
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
        }
    }
}
