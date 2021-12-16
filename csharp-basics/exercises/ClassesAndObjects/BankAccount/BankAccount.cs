using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        private string _name;
        private double _balance;

        public BankAccount(string name, double balance)     
        {
            _name = name;
            _balance = balance;
        }

        public string Name
        {
            get { return _name; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public string ShowUserNameAndBalance()
        {
            string decimalBalance = Math.Abs(Balance).ToString("0.00");
            if(Balance < 0)
                return $"{Name}, -${decimalBalance}"; 
            return $"{Name}, ${decimalBalance}";
        }
    }
}
