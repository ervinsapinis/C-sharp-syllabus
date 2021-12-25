using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public abstract class Food
    {
        private int _quantity;

        public Food(int quantity)
        {
            _quantity = quantity;
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
    }
}
