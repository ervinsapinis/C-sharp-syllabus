using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string _path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var marks = new List<string>
                {"00-09: ", "10-19: ", "20-29: ", "30-39: ", "40-49: ", "50-59: ", "60-69: ", "70-79: ", "80-89: ", "90-99: ", "100: "};
            var _readText = File.ReadAllLines(_path);
            var text = string.Join(" ", _readText);
            var workable = text.Split(' ');

            var gradesList = new List<int>();

            foreach (var s in workable)
            {
                int grade = int.Parse(s);
                gradesList.Add(grade);
            }

            gradesList.Sort();

            foreach (var grade in gradesList)
            {
                var index = grade / 10;
                marks[index] +="*";
            }

            marks.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
