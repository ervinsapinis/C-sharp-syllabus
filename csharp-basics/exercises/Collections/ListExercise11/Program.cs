using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create an List with string elements
            var stringList = new List<string>();

            //TODO: Add 10 values to list
            for (int i = 1; i < 10; i++)
            {
                stringList.Add("Lorem");
            }

            //TODO: Add new value at 5th position
            stringList.Insert(4, "Ipsum");

            //TODO: Change value at last position (Calculate last position programmatically)
            var last = stringList.IndexOf(stringList.Last());
            stringList[last] = "LoremIpsum";
            Console.WriteLine(stringList.Last());

            //TODO: Sort your list in alphabetical order
            stringList.Sort();
            Console.WriteLine(string.Join(",", stringList));

            //TODO: Check if your list contains "Foobar" element
            Console.WriteLine(stringList.Contains("Foobar"));

            //TODO: Print each element of list using loop
            foreach (var word in stringList)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
