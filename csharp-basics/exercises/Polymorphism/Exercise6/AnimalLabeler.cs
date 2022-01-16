using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class AnimalLabeler
    {
        public string NameAnimal(AnimalEnums type)
        {
            AppMessages.RequestName(type.ToString());
            return Console.ReadLine();
        }

        public string LocateAnimal(AnimalEnums type)
        {
            AppMessages.RequestLocation(type.ToString());
            return Console.ReadLine();
        }

        public double WeighAnimal(AnimalEnums type)
        {
            AppMessages.RequestWeight(type.ToString());
            var isDouble = double.TryParse(Console.ReadLine(), out var weight);
            while (!isDouble)
            {
                AppMessages.InvalidWeight();
                isDouble = double.TryParse(Console.ReadLine(), out weight);
            }
            return weight;
        }

        public string IdentifyAnimalBreed(AnimalEnums input)
        {
            AppMessages.RequestBreed(input.ToString());
            return Console.ReadLine();
        }
    }
}
