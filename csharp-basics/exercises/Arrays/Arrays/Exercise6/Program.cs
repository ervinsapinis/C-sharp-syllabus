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
}
