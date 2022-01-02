using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class SavingsAccount
    {
        //fields
        private decimal _balance;
        private decimal _monthlyInterest;
        private decimal _interestEarned;

        //ctor
        public SavingsAccount(int balance, int interest)
        {
            _balance = balance;
            _monthlyInterest = (decimal)interest / 12;
            _interestEarned = 0;
        }
        //properties

        public decimal Balance
        {
            get => _balance;
            private set => _balance = value;
        }

        public decimal MonthlyInterest
        {
            get => _monthlyInterest;
            private set => _monthlyInterest = value;
        }

        public decimal InterestEarned
        {
            get => _interestEarned;
            private set => _interestEarned = value;
        }

        //methods
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal EarnInterest()
        {
            InterestEarned = MonthlyInterest * Balance;
            Balance += InterestEarned;
            return InterestEarned;
        }


    }
}
