using System;
using System.Runtime.InteropServices;

namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string v1, double v2)
        {
            _name = v1;
            _money = v2;
        }

        public double Withdrawal(double i)
        {
            if (i < Money)
            {
                Money -= i;
                Console.WriteLine($"A withdrawal of {i} from {Name} is made.");
                return i;
            }
            else
            {
                 Console.WriteLine("Not enough money to make a withdrawal!");
                 return 0;
            }

        }

        public void Deposit(double i)
        {
            Money += i;
            Console.WriteLine($"A deposit of {i} from {Name} is made.");
        }

        public double Balance()
        {
            return Money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        private double Money
        {
             get => _money;
             set => _money = value;
            
        }
    }
}
