using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    enum AnimalEnums
    {
        Cat,
        Tiger,
        Zebra,
        Mouse
    };
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

                switch (ValidInput(userInput))
                {
                    case nameof(AnimalEnums.Tiger):
                    case nameof(AnimalEnums.Zebra):
                    case nameof(AnimalEnums.Mouse):
                        CatalogueAnimal(userInput.ToLower());
                        break;
                    case nameof(AnimalEnums.Cat):
                        CatalogueAnimal(userInput.ToLower());
                        break;
                }
            }
        }

        private string ValidInput(string input)
        {
            input = input.ToLower();
            var firstLetter = char.ToUpper(input[0]).ToString();
            string result = firstLetter;
            result += input.Substring(1);
            return result;
        }

        public void CatalogueAnimal(string input)
        {
            if (input == AnimalEnums.Tiger.ToString() | input == AnimalEnums.Zebra.ToString()| input == AnimalEnums.Mouse.ToString())
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
                if (animal is Cat cat)
                {
                    result += $"{animal.Type}[{animal.Name}, {animal.Weight}, {animal.LivingRegion}, {animal.FoodEaten}, {cat.Breed}]\n";
                    
                }
                else
                    result += $"{animal.Type}[{animal.Name}, {animal.Weight}, {animal.LivingRegion}, {animal.FoodEaten}]\n";
            }
            return result;
        }

    }
}
