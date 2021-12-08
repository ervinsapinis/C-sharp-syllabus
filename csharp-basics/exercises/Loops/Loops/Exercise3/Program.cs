using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int rand = r.Next(0, 100);
                arr[i] = rand;
            }

            Console.WriteLine("Please input an index of the array. 1 - 20");

            bool isBool;
            string input;
            int inputInt;
            input = Console.ReadLine();
            isBool = int.TryParse(input, out inputInt);
            while (!isBool)
            {
                Console.WriteLine("Please input an integer.");
                input = Console.ReadLine();
                isBool = int.TryParse(input, out inputInt);
                while (inputInt > 20 || inputInt < 0)
                {
                    Console.WriteLine("Please input an integer: 1 - 20");
                    input = Console.ReadLine();
                    isBool = int.TryParse(input, out inputInt);
                }
            }

        }
    }
}
