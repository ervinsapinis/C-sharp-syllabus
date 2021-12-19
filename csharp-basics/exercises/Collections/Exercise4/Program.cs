using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Provide an integer to check if it is happy:");
            var number = int.Parse(Console.ReadLine());

            if (PowerSum(number) == 1)
                Console.WriteLine(true);
            else if (PowerSum(number) < 10 && PowerSum(number) != 1)
                Console.WriteLine(false);
            else
            {
                int sum = PowerSum(number);
                while (true)
                {
                    if (PowerSum(sum) == 1)
                    {
                        Console.WriteLine(true);
                        break;
                    }

                    if (PowerSum(sum) < 10 && PowerSum(sum) != 1)
                    {
                        Console.WriteLine(false);
                        break;
                    }
                    sum = PowerSum(sum);
                }
            }
            Console.ReadKey();
        }

        static int PowerSum(int input)
        {
            var numList = input.ToString().ToCharArray().ToList();
            int sum = 0;
            foreach (var numChar in numList)
            {
                int num = int.Parse(numChar.ToString());
                sum += (int)Math.Pow(num, 2);
            }
            return sum;
        }
    }
}
