using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    internal class NumberSquare
    {
        public static void Call()
        {
            Console.WriteLine("Please input min value");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input max value");
            int max = int.Parse(Console.ReadLine());

            for (int row = 0; row < max; row++)
            {
                for (int col = 0; col < max; col++)
                {
                    Console.Write(min);
                    min++;
                    if (min == max+1)
                    {
                        min -= max;
                    }
                }
                min++;
                Console.WriteLine();
            }
        }
    }
}
