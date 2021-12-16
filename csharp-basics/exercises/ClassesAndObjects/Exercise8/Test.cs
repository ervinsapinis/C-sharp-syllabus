using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Test
    {
        public static void Run()
        {
            decimal totalDeposits = 0;
            decimal totalWithdrawals = 0;
            decimal totalEarnings = 0;

            Console.WriteLine("How much money is in the account?");
            int balance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the annual interest rate:");
            int rate = int.Parse(Console.ReadLine());
            Console.WriteLine("How many months has the account been opened?");
            int months = int.Parse(Console.ReadLine());

            SavingsAccount myAccount = new SavingsAccount(balance, rate);

            for (int i = 1; i <= months; i++)
            {
                Console.WriteLine($"Enter amount deposited for month {i}:");
                int amountDeposited = int.Parse(Console.ReadLine());
                myAccount.Deposit(amountDeposited);
                totalDeposits += amountDeposited;
                Console.WriteLine($"Enter amount withdrawn for month {i}:");
                int amountWithdrawn = int.Parse(Console.ReadLine());
                myAccount.Withdraw(amountWithdrawn);
                totalWithdrawals += amountWithdrawn;
                myAccount.EarnInterest();
                totalEarnings += myAccount.InterestEarned;
            }

            Console.WriteLine($"Total deposited: ${totalDeposits}");
            Console.WriteLine($"Total withdrawn: ${totalWithdrawals}");
            Console.WriteLine($"Total earnings in interest: ${Math.Round(totalEarnings, 2)}");
            Console.WriteLine($"Account balance at the end of term: ${Math.Round(myAccount.Balance, 2)}");
        }
    }
}
