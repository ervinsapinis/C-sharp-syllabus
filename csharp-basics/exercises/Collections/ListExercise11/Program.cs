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
            var stringList = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                stringList.Add("Lorem");
            }

            stringList.Insert(4, "Ipsum");

            var last = stringList.IndexOf(stringList.Last());
            stringList[last] = "LoremIpsum";
            Console.WriteLine(stringList.Last());

            stringList.Sort();
            Console.WriteLine(string.Join(",", stringList));

            Console.WriteLine(stringList.Contains("Foobar"));

            foreach (var word in stringList)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
