using System;
using System.Runtime.InteropServices;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int result = 0;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                result = i * i;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
