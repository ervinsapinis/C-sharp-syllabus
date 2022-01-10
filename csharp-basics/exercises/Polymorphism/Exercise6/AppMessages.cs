using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class AppMessages
    {
        public static void InvalidInput()
        {
            Console.WriteLine("Invalid input. Try again.");
        }

        public static void PrintAnimalInfo(AnimalCatalogue input)
        {
            Console.WriteLine(input.ShowAnimalInfo());
        }

        public static void PrintAnimalChoices(AnimalCatalogue input)
        {
            Console.WriteLine(
                "Choose an animal to create. Otherwise input `End` to stop the program. Possible animal choices:");
            Console.WriteLine(input.ShowAnimalChoices());
        }

        public static void RequestName(string input)
        {
            Console.WriteLine($"Input your {input}'s name:");
        }

        public static void RequestLocation(string input)
        {
            Console.WriteLine($"Input your {input}'s region:");
        }

        public static void RequestWeight(string input)
        {
            Console.WriteLine($"Input your {input}'s weight:");
        }

        public static void RequestBreed(string input)
        {
            Console.WriteLine($"Input your {input}'s breed:");
        }

        public static void InvalidWeight()
        {
            Console.WriteLine("Error. Please provide valid weight.");
        }

        public static void InputFoodType()
        {
            Console.WriteLine("Please provide the type of food (meat or vegetable) for your pet.");
        }

        public static void InputFoodAmount()
        {
            Console.WriteLine("Please provide the amount of feed.");
        }

        public static void FoodError()
        {
            Console.WriteLine("Error. Please provide valid food types/amounts.");
        }

        public static void InvalidFoodGiven()
        {
            Console.WriteLine("This animal can't eat that.");
        }

        public static void PrintAnimalSound(Animal inputAnimal)
        {
            Console.WriteLine(inputAnimal.MakeSound());
        }



    }
}
