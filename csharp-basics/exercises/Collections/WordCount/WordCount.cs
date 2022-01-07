using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    public class WordCount
    {
        private static string _directory;
        private Regex rgx = new Regex("[^a-zA-Z0-9 -,]");

        public WordCount(string directory)
        {
            _directory = directory;
        }

        public string FileText()
        {
            return System.IO.File.ReadAllText(_directory);
        }

        public int CountOfLines()
        {
            string[] lines = System.IO.File.ReadAllLines(_directory);
            return lines.Length;
        }

        public int CountOfWords()
        {
            return Regex.Matches(FileText(), @"[A-Za-z]+").Count;
        }

        public int CountOfChars()
        {
            return rgx.Replace(FileText(), "").Length;
        }
    }
}
