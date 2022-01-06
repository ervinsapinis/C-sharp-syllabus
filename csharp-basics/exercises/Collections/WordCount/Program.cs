using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var lear = new WordCount(@"..\..\lear.txt");

            Console.WriteLine(lear.FileText());
            Console.WriteLine();
            Console.WriteLine("Lines = " + lear.CountOfLines());
            Console.WriteLine("Words = " + lear.CountOfWords());
            Console.WriteLine("Chars = " + lear.CountOfChars());
            Console.ReadKey();
        }
    }
}
