using System;
using System.Linq;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomArr = new int[10];
            for (int i = 0; i < randomArr.Length; i++)
            {
                Random rnd = new Random();
                randomArr[i] = rnd.Next(1, 100);
            }

            int[] randomArrCopy = new int[randomArr.Length];
            Array.Copy(randomArr, randomArrCopy, randomArr.Length);
            randomArrCopy[randomArrCopy.Length - 1] = -7;

            Console.WriteLine("Array 1: {0}", string.Join(", ", randomArr));
            Console.WriteLine("Array 2: {0}", string.Join(", ", randomArrCopy));
        }
    }
}
