using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    public static class CheckOddEven
    {
        public static string ByeMessage()
        {
            return "Bye!";
        }

        public static string CheckValue(int x)
        {
            if (x % 2 == 0) return "Even number";
            else return "Odd number";
        }
    }
}
