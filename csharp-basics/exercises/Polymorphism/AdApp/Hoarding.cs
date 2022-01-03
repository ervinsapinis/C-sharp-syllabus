using System.Reflection.Metadata;

namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _ratePerDay;
        private int _numDays;
        private int _primeLocationCharge;
        private bool _isPrimeLocation = false;

        public Hoarding() : base(rate)
        {
        }
        public Hoarding(int rate, int days, int extraCharge) : base(rate)
        {
            _ratePerDay = rate;
            _numDays = days;
            _primeLocationCharge = extraCharge;
        }

        public int RatePerDay
        {
            get => _ratePerDay;
            set => _ratePerDay = value;
        }

        public int NumDays
        {
            get => _numDays;
            set => _numDays = value;
        }

        public bool IsPrimeLocation
        {
            get => _isPrimeLocation;
            set => _isPrimeLocation = value;
        }

        public int PrimeLocationCharge
        {
            get => _primeLocationCharge;
            set => _primeLocationCharge = value;
        }
        
        public new int Cost() 
        {
            return base.Cost();
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}