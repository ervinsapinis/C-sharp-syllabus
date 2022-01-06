using System;
using System.Linq;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var randomArr = MakeArrays.CreateEmptyArrayOf10();
            MakeArrays.FillArr(randomArr);
            var randomArrCopy = MakeArrays.CopyArrAndReplaceLastElement(randomArr);
            Console.WriteLine("Array 1: {0}", string.Join(", ", randomArr));
            Console.WriteLine("Array 2: {0}", string.Join(", ", randomArrCopy));
        }
    }

    public static class MakeArrays
    {
        public static int[] CreateEmptyArrayOf10()
        {
            var arr = new int[10];
            return arr;
        }

        public static int[] FillArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Random rnd = new Random();
                arr[i] = rnd.Next(1, 100);
            }
            return arr;
        }

        public static int[] CopyArrAndReplaceLastElement(int[] arr)
        {
            int[] arrCopy = new int[arr.Length];
            arrCopy[arr.Length - 1] = -7;
            return arrCopy;
        }
    }
      
}
