using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Exercise5
{
    internal class Date
    {
        //fields
        private int _year;
        private int _month;
        private int _day;

        //ctor
        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        //properties
        public int Day
        { get { return _day; } }
        public int Month
        { get { return _month; } }
        public int Year
        { get { return _year; } }

        //methods
        public void DisplayDate()
        {
            Console.WriteLine($"{Day}/{Month}/{Year}");
        }
    }
}
