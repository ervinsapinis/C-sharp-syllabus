using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            int input3 = int.Parse(Console.ReadLine());

            int max1, max2;

            max1 = Math.Max(input1, input2);
            max2 = Math.Max(input1, input3);

            Console.WriteLine(max1 > max2 ? $"The largest number is: {max1}" : $"The largest number is: {max2}");
        }
    }
}
