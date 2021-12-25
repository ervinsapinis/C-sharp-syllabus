using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
     class Commission : Hourly
     {
         protected double _totalSales;
         protected double _commissionRate;
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate)
            : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            var salary = base.Pay() + (_totalSales + _commissionRate*0.01);
            _totalSales = 0;
            return Math.Round(salary, 2);
        }
     }
}
