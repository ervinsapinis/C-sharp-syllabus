using Xunit;
using FlightPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FlightPlanner.Tests
{
    public class FlightPlannerTests
    {
        FlightPlanner _target = new FlightPlanner(@"..\..\flights.txt");


        [Fact()]
        public void FillDictionary_ShouldReturnPopulatedList()
        {
            //Arrange
            var expected = new Dictionary<string, List<string>>()
            {
                { "Berlin", new List<string> { "Warsaw", "Tallin" } },
                { "Riga", new List<string> { "Tallin", "Berlin", "Warsaw", "Malta" } },
                { "Tallin", new List<string> { "Riga", "Berlin" } },
                { "Malta", new List<string> { "Riga", "Warsaw" } },
                { "Zurich", new List<string> { "Berlin" } },
                { "Warsaw", new List<string> { "Riga", "Malta", "Zurich" } },
            };
            //Act
            var actual = _target.FlightDictionary;
            actual = _target.FillDictionary();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void AddCityToTravelList_Input_ShouldAddCity()
        {
            //Arrange
            var expected = new List<string> { "Vilnius" };
            //Act
            var actual = _target.travelList;
            _target.AddCityToTravelList("Vilnius");
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CityChoice_Berlin_ShouldReturnWarsawAndTallin()
        {
            //Arrange
            var expected = "--) Warsaw\n--) Tallin\nChoose and input your next destination:";
            _target.FlightDictionary = _target.FillDictionary();
            //Act
            var actual = _target.CityChoice("Berlin");
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Route_ShouldReturn()
        {
            //Arrange
            var testList = new List<string> { "Berlin", "Tallin", "Berlin" };
            var expected = "Thanks for using the flight planner. Here is your route:\nBerlin -> Tallin -> Berlin";
            //Act
            var actual = _target.Route(testList);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void PrintCities_TargetFlightDictionary_ShouldReturnStringOfAllKeys()
        {
            //Arrange
            var expected = "Berlin\nRiga\nTallin\nMalta\nZurich\nWarsaw\n";
            _target.FillDictionary();
            //Act
            _target.FlightDictionary = _target.FillDictionary();
            var actual = _target.PrintCities();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void ShowMenu_ShouldReturnMenu()
        {
            //Arrange
            var expected = "What would you like to do: \n To display list of the cities press 1 \n To exit program press #";
            //Act
            var actual = _target.ShowMenu();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CloseApp_ShouldReturnGoodbyeMessage()
        {
            //Arrange
            var expected = "Fly safe. Goodbye!";
            //Act
            var actual = _target.CloseApp();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CloseApp_IsAppRunningShouldBeFalse()
        {
            //Act
            _target.CloseApp();
            //Assert
            Assert.True(!_target.IsAppRunning);
        }
    }
}