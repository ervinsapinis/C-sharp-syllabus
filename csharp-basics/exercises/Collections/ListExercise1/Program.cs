using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();

            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("Yellow");
            colors.Add("Purple");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
