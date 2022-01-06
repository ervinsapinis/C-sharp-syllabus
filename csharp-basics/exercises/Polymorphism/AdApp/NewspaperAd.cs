using System.Reflection.Metadata;

namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _cm;

        public NewspaperAd(int fee) : base(fee)
        {
        }

        public NewspaperAd(int column, int cm, int fee) : base(fee)
        {
            _column = column;
            _cm = cm;
        }

        public int Column => _column;
        public int Centimeters => _cm;

        private new int Cost()
        {
            var fee = base.Cost();
            return fee += Centimeters * Column;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}