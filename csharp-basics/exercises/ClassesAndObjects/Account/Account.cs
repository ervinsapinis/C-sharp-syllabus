using System;
using System.Runtime.InteropServices;

namespace Account
{
    public class Account
    {
        private string _name;
        private double _money;

        public Account(string v1, double v2)
        {
            _name = v1;
            _money = v2;
        }

        public string Withdrawal(double i)
        {
            if (i < Money)
            {
                _money -= i;
                return $"A withdrawal of {i} from {Name} is made.";
            }
            else
            {
                return "Not enough money to make a withdrawal!";
            }
        }

        public string Deposit(double i)
        {
            if (i > 0)
            {
                _money += i;
                return $"A deposit of {i} to {Name} is made.";
            }
            return "Can't make a deposit with a negative value.";
        }

        public double Balance()
        {
            return Money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Transfer(Account toAccount, double amount)
        {
            if (_money > amount)
            {
                _money -= amount;
                toAccount.Money += amount;
                return $"{amount}$ successfully transferred from {Name} to {toAccount.Name}";
            } 
            return "Not enough money to make this transfer.";
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
