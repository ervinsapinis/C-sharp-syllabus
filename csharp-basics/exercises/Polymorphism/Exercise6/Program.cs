using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var katalogs = new AnimalCatalogue();
            katalogs.LaunchApp();
            AppMessages.PrintAnimalInfo(katalogs);
        }
    }
}