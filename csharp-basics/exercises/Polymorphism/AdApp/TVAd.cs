namespace AdApp
{
    public class TVAd: Advert
    {
        private int _seconds;
        private bool _isPeakTime = false;

        public TVAd(int fee) : base(fee)
        {
        }

        public TVAd(int fee, int seconds, bool isPeak) : base(fee)
        {
            _seconds = seconds;
            _isPeakTime = isPeak;
        }

        public int Seconds => _seconds;

        public bool IsPeakTime => _isPeakTime;

        public new int Cost() 
        {
            var fee = base.Cost();
            fee = fee * Seconds;
            if (IsPeakTime)
                return fee * 2;
            return fee;

        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}