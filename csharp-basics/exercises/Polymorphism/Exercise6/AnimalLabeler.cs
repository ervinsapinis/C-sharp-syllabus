using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class AnimalLabeler
    {
        public string NameAnimal(string type)
        {
            AppMessages.RequestName(type);
            return Console.ReadLine();
        }

        public string LocateAnimal(string type)
        {
            AppMessages.RequestLocation(type);
            return Console.ReadLine();
        }

        public double WeighAnimal(string type)
        {
            AppMessages.RequestWeight(type);
            var isDouble = double.TryParse(Console.ReadLine(), out var weight);
            while (!isDouble)
            {
                AppMessages.InvalidWeight();
                isDouble = double.TryParse(Console.ReadLine(), out weight);
            }
            return weight;
        }

        public string IdentifyAnimalBreed(string input)
        {
            AppMessages.RequestBreed(input);
            return Console.ReadLine();
        }
    }
}
