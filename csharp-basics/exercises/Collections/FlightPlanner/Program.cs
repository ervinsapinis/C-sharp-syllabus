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
        private static void Main(string[] args)
        {
            FlightPlanner myTravelOptions = new FlightPlanner(@"..\..\flights.txt");

            myTravelOptions.FlightDictionary = myTravelOptions.FillDictionary();
            Console.WriteLine(myTravelOptions.ShowMenu());
            string[] validInputs = {"1", "#"};
            var userInput = Console.ReadLine();
            while (!validInputs.Contains(userInput)) 
            {
                Console.WriteLine("Invalid Input. Please choose 1 to continue or # to exit.");
                userInput = Console.ReadLine();
            }

            if (userInput == validInputs[1])
                Console.WriteLine(myTravelOptions.CloseApp());
            else
                Console.WriteLine(myTravelOptions.PrintCities());

            var tempInputCity = Console.ReadLine();
            var firstInputCity = tempInputCity;
            myTravelOptions.AddCityToTravelList(firstInputCity);
            while (myTravelOptions.IsAppRunning)
            {
                Console.WriteLine();
                Console.WriteLine(myTravelOptions.CityChoice(tempInputCity));
                Console.WriteLine();
                tempInputCity = Console.ReadLine();
                myTravelOptions.AddCityToTravelList(tempInputCity);
                if (firstInputCity == tempInputCity)
                {
                    Console.WriteLine(myTravelOptions.Route(myTravelOptions.travelList));
                    Console.WriteLine(myTravelOptions.CloseApp());
                }
            }
            Console.ReadKey();
        }
    }
}
