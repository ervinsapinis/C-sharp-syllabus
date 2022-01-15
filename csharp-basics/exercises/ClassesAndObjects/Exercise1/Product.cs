using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Product
    {
        //fields
        private string _name;
        private double _priceAtStart;
        private int _amountAtStart;

        //constructor
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            this._name = name;
            this._priceAtStart = priceAtStart;
            this._amountAtStart = amountAtStart;
        }

        //methods
        public string PrintProduct()
        {
            return $"{_name}, price: {_priceAtStart} EUR, amount: {_amountAtStart} units";
        }

        public int ChangeQuantity(int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException();
            else
            {
                this._amountAtStart = amount;
                return amount;
            }
        }

        public double ChangePrice(double amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException();
            else
            {
                this._priceAtStart = amount;
                return amount;
            }
        }
    }
}
