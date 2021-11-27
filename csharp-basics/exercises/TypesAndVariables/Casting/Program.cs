using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Console.ReadKey();
        }

        static void First()
        {
            string aString = "1";
            int a = int.Parse(aString);           
            int b = 2;
            int c = 3;
            double dDouble = 4;
            int d = (int)dDouble;
            float eFloat = 5;
            int e = (int)eFloat;

            //fixme - should be 15 :|
            int sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }

        static void Second()
        {
            string aString = "1";
            int a = int.Parse(aString);
            int b = 2;
            int c = 3;
            double dDouble = 4.2;
            float d = (float)dDouble;
            float e = 5.3f;

            //fixme - should be 15.5 :| 
            float sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }
    }
}
