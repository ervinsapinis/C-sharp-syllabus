using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            //first account
            Account bartosAccount = new Account("Barto's account", 100.00);
            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);

            Console.WriteLine(bartosAccount.Withdrawal(20));
            Console.WriteLine("Barto's account balance is now: " + bartosAccount.Balance());

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);

            //first money xfer
            Console.WriteLine("Initial state");
            Account mattsAccount = new Account("Matt's account", 1000);
            Account myAccount = new Account("My Account", 0);
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);
            Console.WriteLine();

            Console.WriteLine(mattsAccount.Withdrawal(100));
            Console.WriteLine(myAccount.Deposit(100));
            Console.WriteLine("Final state");
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);
            Console.WriteLine();


            //money xfers
            Console.WriteLine("Initial state");
            Account aAccount = new Account("A", 100);
            Account bAccount = new Account("B", 0);
            Account cAccount = new Account("C", 0);
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);
            Console.WriteLine(aAccount.Transfer(bAccount, 50));
            Console.WriteLine(aAccount.Transfer(cAccount, 25));
            Console.WriteLine();
            Console.WriteLine("Final state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);
            Console.ReadKey();
        }
    }
}
