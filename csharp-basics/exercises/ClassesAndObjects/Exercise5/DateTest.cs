using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class DateTest
    {
        public static void Run()
        {
            Console.WriteLine("Enter day:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());

            Date date = new Date(day, month, year);
            date.DisplayDate();
        }
    }
}
