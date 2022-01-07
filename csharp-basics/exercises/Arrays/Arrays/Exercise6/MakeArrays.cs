using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
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
