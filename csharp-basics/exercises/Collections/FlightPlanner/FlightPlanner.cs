using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class FlightPlanner
    {
        private string _path;
        private Dictionary<string, List<string>> _flightDictionary = new Dictionary<string, List<string>>();
        private bool _isAppRunning = true;
        public List<string> travelList = new List<string>();

        public FlightPlanner(string path)
        {
            _path = path;
        }

        public bool IsAppRunning { get { return _isAppRunning; } }

        public Dictionary<string, List<string>> FlightDictionary
        {
            get { return _flightDictionary; }
            set { _flightDictionary = value; }
        }

        private List<string> ReadText()
        {
            return File.ReadAllLines(_path).ToList();
        }

        public Dictionary<string, List<string>> FillDictionary()
        {
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
            foreach (var item in ReadText())
            {
                string[] splitted = Regex.Split(item, " -> ");
                if (output.ContainsKey(splitted[0]))
                {
                    output[splitted[0]].Add(splitted[1]);
                }
                else
                {
                    output.Add($"{splitted[0]}", new List<string> { splitted[1] });
                }
            }
            return output;
        }

        public void AddCityToTravelList(string input)
        {
                travelList.Add(input);
        }

        public string CityChoice(string input)
        {
            string cityChoices = string.Empty;
            _flightDictionary[input].ForEach(city => cityChoices += $"--) {city}\n");
            cityChoices += "Choose and input your next destination:";
            return cityChoices;
        }

        public string Route(List<string> input)
        {
            string message = "Thanks for using the flight planner. Here is your route:\n";
            message += string.Join(" -> ", input);
            return message;
        }

        public string PrintCities()
        {
            string listOfCities = String.Empty;
            Console.WriteLine("Choose the city you want to start your round trip from:");
            foreach (var city in _flightDictionary)
            {
                listOfCities += $"{city.Key}\n";
            }
            return listOfCities;
        }

        public string ShowMenu()
        {
            return "What would you like to do: \n To display list of the cities press 1 \n To exit program press #";
        }

        public string CloseApp()
        {
            _isAppRunning = false;
            return "Fly safe. Goodbye!";
        }
    }
}
