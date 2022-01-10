using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class AnimalLabeler : UserInput
    {
        public string NameAnimal(string type)
        {
            AppMessages.RequestName(type);
            return Read();
        }

        public string LocateAnimal(string type)
        {
            AppMessages.RequestLocation(type);
            return Read();
        }

        public double WeighAnimal(string type)
        {
            AppMessages.RequestWeight(type);
            var isDouble = double.TryParse(Read(), out var weight);
            while (!isDouble)
            {
                AppMessages.InvalidWeight();
                isDouble = double.TryParse(Read(), out weight);
            }
            return weight;
        }

        public string IdentifyAnimalBreed(string input)
        {
            AppMessages.RequestBreed(input);
            return Read();
        }
    }
}
