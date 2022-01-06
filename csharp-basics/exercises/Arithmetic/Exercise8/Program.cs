using System;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your base pay:");
            double  basePay = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input how many hours you've worked:");
            int hoursWorked = int.Parse(Console.ReadLine());

            Console.WriteLine(WageCalculator.TotalPay(basePay, hoursWorked));
            Console.ReadKey();
        }

    }

    public static class WageCalculator
    {
        public static string TotalPay(double basePay, int hoursWorked)
        {
            if (basePay < 8)
            {
                return "Error: base pay cannot be less than $8.00 per hour!";
            }
            else if (hoursWorked > 60)
            {
                return "Error: employees may not work more than 60h per week!";
            }
            else if (hoursWorked > 40)
            {
                double total = (((hoursWorked - 40) * 1.5) + 40) * basePay;
                return "Your total pay is: $" + total;
            }
            else
            {
                double total = hoursWorked * basePay;
                return "Your total pay is: $" + total;
            }
        }
    }
}
