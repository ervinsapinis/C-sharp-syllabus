using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public enum AnimalEnums
    {
        Cat,
        Tiger,
        Zebra,
        Mouse
    };
    
    public class AnimalCatalogue : AnimalLabeler
    {
        public AnimalGenerator deus = new AnimalGenerator();
        public List<Mammal> animalList = new();
        public int animalCounter;
        public AnimalFeeder feeder = new();

        public void LaunchApp()
        {
            while (true)
            {
                AppMessages.PrintAnimalChoices(this);
                var userInput = Console.ReadLine();
                if (userInput.ToLower() == "end")
                    break;
                var isValid = Enum.TryParse(userInput, true, out AnimalEnums userInputEnum);
                while (!isValid)
                {
                    AppMessages.InvalidInput();
                    userInput = Console.ReadLine();
                    break;
                }

                switch (userInputEnum)
                {
                    case AnimalEnums.Tiger:
                    case AnimalEnums.Mouse:
                    case AnimalEnums.Zebra:
                        CatalogueAnimal(userInputEnum);
                        break;
                    case AnimalEnums.Cat:
                        CatalogueAnimal(userInputEnum);
                        break;
                }
            }
        }

        public void CatalogueAnimal(AnimalEnums input)
        {
            var name = NameAnimal(input);
            var weight = WeighAnimal(input);
            var region = LocateAnimal(input);
            if (input == AnimalEnums.Tiger | input == AnimalEnums.Zebra| input == AnimalEnums.Mouse)
            {
                animalList.Add(deus.CreateAnimal(input, name, weight, region));
            }
            else
            {
                var breed = IdentifyAnimalBreed(input);
                animalList.Add(deus.CreateCat(input, name, weight, region, breed));
            }

            AppMessages.PrintAnimalSound(animalList[animalCounter]);
            animalList[animalCounter].Eat(feeder.FeedAnimal());
            animalCounter++;
        }

        public string ShowAnimalChoices()
        {
            var values = Enum.GetValues(typeof(AnimalEnums));
            var output = string.Empty;
            foreach (var choice in values)
                output += $"{choice}\n";
            return output;
        }

        public string ShowAnimalInfo()
        {
            var result = string.Empty;
            foreach (var animal in animalList)
            {
                result += $"{animal.Type}[{animal.Name}, {animal.Weight}, {animal.LivingRegion}, {animal.FoodEaten}";
                if (animal is Cat cat)
                    result += $", {cat.Breed}";
            }
            return result + "]\n";
        }
    }
}
