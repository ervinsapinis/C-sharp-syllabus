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
            string text = System.IO.File.ReadAllText(
                @"D:\codelex\mans repository\C-sharp-syllabus\csharp-basics\exercises\Collections\WordCount\lear.txt");
            string[] lines = System.IO.File.ReadAllLines(
                @"D:\codelex\mans repository\C-sharp-syllabus\csharp-basics\exercises\Collections\WordCount\lear.txt");
            var wordCount= Regex.Matches(text, @"[A-Za-z]+").Count;
            Regex rgx = new Regex("[^a-zA-Z0-9 -,]");
            string cleanCharString = rgx.Replace(text, "");


            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine("Lines = " + lines.Length);
            Console.WriteLine("Words = " + wordCount);
            Console.WriteLine("Chars = " + cleanCharString.Length);
            Console.ReadKey();

        }
    }
}
