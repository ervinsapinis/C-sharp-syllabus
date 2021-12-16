using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class AsciiFigure
    {
        public static void DrawFigure()
        {
            int n = int.Parse(Console.ReadLine());
            int halfLength = n * 3 + n - 4;
            int topLength = 0;
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('/', halfLength - topLength));
                Console.Write(new string('*', topLength * 2));
                Console.Write(new string('\\', halfLength - topLength));
                Console.WriteLine();
                topLength += 4;
            }
        }
    }
}
