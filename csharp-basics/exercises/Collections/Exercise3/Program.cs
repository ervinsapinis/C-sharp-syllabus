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
            var namesList = new HashSet<string>();
            while (true)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                if (name != "") namesList.Add(name);
                else break;
            }

            Console.WriteLine("Unique name list contains: " + string.Join(" ", namesList));
            Console.ReadKey();
        }
    }
}
