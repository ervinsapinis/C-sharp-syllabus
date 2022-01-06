using System;
using System.Collections.Generic;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> testHasHashSet = new HashSet<string>();
            testHasHashSet.Add("one");
            testHasHashSet.Add("two");
            testHasHashSet.Add("three");
            testHasHashSet.Add("four");
            testHasHashSet.Add("five");

            foreach (var var in testHasHashSet)
            {
                Console.WriteLine(var);
            }

            testHasHashSet.Clear();

            testHasHashSet.Add("one");
            testHasHashSet.Add("two");
            testHasHashSet.Add("one");

            foreach (var var in testHasHashSet)
            {
                Console.WriteLine(var);
            }
            // not poss to add duped values.
        }
    }
}
