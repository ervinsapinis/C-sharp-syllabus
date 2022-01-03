using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public abstract class Mammal : Animal
    {
        private string _livingRegion;
        public Mammal(string name, string type, double weight, string livingRegion)
            : base(name, type, weight)
        {
            _livingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get { return _livingRegion; }
            set { _livingRegion = value; }
        }
    }
}
