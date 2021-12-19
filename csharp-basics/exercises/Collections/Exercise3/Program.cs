using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesList = new List<string>();
            while (true)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                if (name != "")
                    namesList.Add(name);
                else
                    break;
            }

            var uniqueNamesList = namesList.Distinct();
            Console.WriteLine("Unique name list contains: " + string.Join(" ", uniqueNamesList));
            Console.ReadKey();
        }
    }
}
