using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Product
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
        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price: {_priceAtStart} EUR, amount: {_amountAtStart} units");
        }

        public void ChangeQuantity(int amount)
        {
            this._amountAtStart = amount;
        }

        public void ChangePrice(double amount)
        {
            this._priceAtStart = amount;
        }
    }
}
