using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, string type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion)
        {
        }
    }
}
