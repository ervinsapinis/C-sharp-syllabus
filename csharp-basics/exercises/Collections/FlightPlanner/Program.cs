using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private static string Path = "../../flights.txt";
        private static Dictionary<string, List<string>> flightDictionary = new Dictionary<string, List<string>>();
        private static List<string> readText = File.ReadAllLines(Path).ToList();
        private static bool isAppRunning = true;



        private static void Main(string[] args)
        {
            FillDictionary();
            Menu();
            string[] validInputs = {"1", "#"};
            var userInput = Console.ReadLine();
            while (!validInputs.Contains(userInput)) 
            {
                Console.WriteLine("Invalid Input. Please choose 1 to continue or # to exit.");
                userInput = Console.ReadLine();
            }

            if (userInput == validInputs[1])
                CloseApp();
            else
                PrintCities();

            var tempInputCity = Console.ReadLine();
            var firstInputCity = tempInputCity;
            var travelList = new List<string>();
            travelList.Add(firstInputCity);

            while (isAppRunning)
            {
                Console.WriteLine();
                flightDictionary[tempInputCity].ForEach(city => Console.WriteLine($"--) {city}"));
                Console.WriteLine("Choose and input your next destination:");
                Console.WriteLine();
                tempInputCity = Console.ReadLine();
                travelList.Add(tempInputCity);
                if (firstInputCity == tempInputCity)
                {
                    Console.WriteLine("Thanks for using the flight planner. Here is your route:");
                    Console.WriteLine(string.Join(" -> ",travelList));
                    CloseApp();
                }
            }

            Console.ReadKey();
        }

        public static void FillDictionary()
        {
            foreach (var item in readText)
            {
                string[] splitted = Regex.Split(item, " -> ");
                if (flightDictionary.ContainsKey(splitted[0]))
                {
                    flightDictionary[splitted[0]].Add(splitted[1]);
                }
                else
                {
                    flightDictionary.Add($"{splitted[0]}", new List<string> {splitted[1]});
                }
            }
        }

        public static void PrintCities()
        {
            Console.WriteLine("Choose the city you want to start your round trip from:");
            foreach (var city in flightDictionary)
            {
                Console.WriteLine(city.Key);
            }
        }

        public static void Menu()
        {
            Console.WriteLine("What would you like to do: \n To display list of the cities press 1 \n To exit program press #");
        }

        public static void CloseApp()
        {
            Console.WriteLine("Fly safe. Goodbye!");
            isAppRunning = false;
            Console.ReadKey();
        }

    }
}
