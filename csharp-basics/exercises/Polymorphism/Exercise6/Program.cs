using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise6
{
    internal class Program
    {
        public static List<Mammal> animalList = new List<Mammal>();
        public static int animalCounter = 0;

        static void Main(string[] args)
        {
            string[] animalChoices = {"cat", "tiger", "zebra", "mouse"};
            string userInput = string.Empty;
            while (true)
            {
                Console.WriteLine("Choose an animal to create. Otherwise input `End` to stop the program. Possible animal choices:");
                foreach (var s in animalChoices)
                    Console.WriteLine(s);
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "end")
                    break;
                while (!animalChoices.Contains(userInput))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    userInput = Console.ReadLine();
                }

                switch (userInput.ToLower())
                {
                    case "tiger":
                        CreateTiger(userInput.ToLower());
                        break;
                    case "cat":
                        CreateCat(userInput.ToLower());
                        break;
                    case "zebra":
                        CreateZebra(userInput.ToLower());
                        break;
                    case "mouse":
                        CreateMouse(userInput.ToLower());
                        break;
                }
            }

            Console.WriteLine();
            foreach (var animal in animalList)
            {
                Console.WriteLine($"{animal.Type}[{animal.Name}, {animal.Weight}, {animal.LivingRegion}, {animal.FoodEaten}]");
            }
        }

        static void CreateTiger(string input)
        {
            string type = input;
            string name = NameAnimal(input);
            double weight = WeighAnimal(input);
            string region = LocateAnimal(input);
            animalList.Add(new Tiger(name, type, weight, region));
            animalList[animalCounter].MakeSound();
            animalList[animalCounter].Eat(FeedAnimal());
            animalCounter++;
        }

        static void CreateMouse(string input)
        {
            string type = input;
            string name = NameAnimal(input);
            double weight = WeighAnimal(input);
            string region = LocateAnimal(input);
            animalList.Add(new Mouse(name, type, weight, region));
            animalList[animalCounter].MakeSound();
            animalList[animalCounter].Eat(FeedAnimal());
            animalCounter++;
        }

        static void CreateZebra(string input)
        {
            string type = input;
            string name = NameAnimal(input);
            double weight = WeighAnimal(input);
            string region = LocateAnimal(input);
            animalList.Add(new Zebra(name, type, weight, region));
            animalList[animalCounter].MakeSound();
            animalList[animalCounter].Eat(FeedAnimal());
            animalCounter++;
        }

        static void CreateCat(string input)
        {
            string type = input;
            string name = NameAnimal(input);
            double weight = WeighAnimal(input);
            string region = LocateAnimal(input);
            Console.WriteLine($"Input your {type}'s breed:");
            string breed = Console.ReadLine();
            animalList.Add(new Cat(name, type, weight, region, breed));
            animalList[animalCounter].MakeSound();
            animalList[animalCounter].Eat(FeedAnimal());
            animalCounter++;
        }

        static Food FeedAnimal()
        {
            Console.WriteLine("Please provide the type of food (meat or vegetable) for your pet.");
            var type = Console.ReadLine();
            Console.WriteLine("Please provide the amount of feed.");
            int amount;
            var isAmountValid = int.TryParse(Console.ReadLine(), out amount);
            while (!isAmountValid)
            {
                Console.WriteLine("Error. Please provide valid food types/amounts.");
                isAmountValid = int.TryParse(Console.ReadLine(), out amount);
            }
            while (true)
            {
                if (type.ToLower() == "vegetable")
                    return new Vegetable(amount);
                if (type.ToLower() == "meat")
                    return new Meat(amount);

                Console.WriteLine("Error. Please provide valid food types/amounts.");
                Console.WriteLine("Please provide the type of food (meat or vegetable) for your pet.");
                type = Console.ReadLine();
            }
        }

        static string NameAnimal(string type)
        {
            Console.WriteLine($"Input your {type}'s name:");
            return Console.ReadLine();
        }

        static string LocateAnimal(string type)
        {
            Console.WriteLine($"Input your {type}'s region:");
            return Console.ReadLine();
        }

        static double WeighAnimal(string type)
        {
            Console.WriteLine($"Input your {type}'s weight:");
            double weight;
            var isDouble = double.TryParse(Console.ReadLine(), out weight);
            while (!isDouble)
            {
                Console.WriteLine("Error. Please provide valid weight.");
                isDouble = double.TryParse(Console.ReadLine(), out weight);
            }
            return weight;
        }
    }
}
