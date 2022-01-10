using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class AnimalCatalogue : AnimalLabeler
    {
        public string[] AnimalChoices { get; } = { "cat", "tiger", "zebra", "mouse" };
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
                while (!ValidAnimalInput(userInput))
                {
                    AppMessages.InvalidInput();
                    userInput = Console.ReadLine();
                }

                switch (userInput.ToLower())
                {
                    case "tiger":
                    case "zebra":
                    case "mouse":
                        CatalogueAnimal(userInput.ToLower());
                        break;
                    case "cat":
                        CatalogueAnimal(userInput.ToLower());
                        break;
                }
            }
        }

        public void CatalogueAnimal(string input)
        {
            if (input == "tiger" | input == "zebra" | input == "mouse")
            {
                var type = input;
                var name = NameAnimal(input);
                var weight = WeighAnimal(input);
                var region = LocateAnimal(input);
                animalList.Add(deus.CreateAnimal(type, name, weight, region));
            }
            else
            {
                var type = input;
                var name = NameAnimal(input);
                var weight = WeighAnimal(input);
                var region = LocateAnimal(input);
                var breed = IdentifyAnimalBreed(input);
                animalList.Add(deus.CreateCat(type, name, weight, region, breed));
            }

            AppMessages.PrintAnimalSound(animalList[animalCounter]);
            animalList[animalCounter].Eat(feeder.FeedAnimal());
            animalCounter++;


        }
        public bool ValidAnimalInput(string input)
        {
            if (AnimalChoices.Contains(input))
                return true;
            return false;
        }

        public string ShowAnimalChoices()
        {
            var output = string.Empty;
            foreach (var choice in AnimalChoices)
                output += $"{choice}\n";
            return output;
        }

        public string ShowAnimalInfo()
        {
            var result = string.Empty;
            foreach (var animal in animalList)
            {
                result += $"{animal.Type}[{animal.Name}, {animal.Weight}, {animal.LivingRegion}, {animal.FoodEaten}]\n";
            }
            return result;
        }

    }
}
