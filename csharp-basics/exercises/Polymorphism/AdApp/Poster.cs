using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdApp
{
    internal class Poster : Advert
    {
        private int _dimensionsSquared;
        private int _copies;

        public Poster(int fee, int dimensions, int copies) : base(fee)
        {
            _dimensionsSquared = dimensions;
            _copies = copies;
        }

        public int DimensionsSquared => _dimensionsSquared;

        public int Copies => _copies;

        public new int Cost()
        {
            var fee = base.Cost() * Copies;
            if(DimensionsSquared >= 10)
                return fee *= 2;
            if(DimensionsSquared >= 20)
                return fee *= 3;
            return fee;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
