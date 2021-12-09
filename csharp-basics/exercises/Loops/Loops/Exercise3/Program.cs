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

            Console.Write("Array: ");
            foreach (var num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.WriteLine("Please select an integer from the array to find its index.");

            bool isBool;
            bool check = true;
            string input;
            int inputInt;
            input = Console.ReadLine();
            isBool = int.TryParse(input, out inputInt);
            check = Array.Exists(arr, x => x == inputInt);

            while (!isBool)
            {
                Console.WriteLine("Please input an integer.");
                input = Console.ReadLine();
                isBool = int.TryParse(input, out inputInt);
                if (check)
                {
                    break;
                }
                else
                {
                    while (!check)
                    {
                        Console.WriteLine("Invalid input. Please select an integer from the array.");
                        input = Console.ReadLine();
                        isBool = int.TryParse(input, out inputInt);
                        check = Array.Exists(arr, x => x == inputInt);
                    }
                }
            }

            int index = Array.IndexOf(arr, inputInt);
            Console.WriteLine($"The index of {inputInt} is {index}");
        }
    }
}
