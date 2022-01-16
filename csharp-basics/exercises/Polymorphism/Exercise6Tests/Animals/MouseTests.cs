using Xunit;
using Exercise6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6.Tests
{
    public class MouseTests
    {
        private Mouse _target = new("Mikijs", "Laukue pele", 0.6, "Majas");

        [Fact()]
        public void MakeSound_ShouldReturnSqeekSquuek()
        {
            //Arrange
            var expected = "squuek squeek!";
            //Act
            var actual = _target.MakeSound();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Eat_ValidInput_ShouldIncrementFoodEaten()
        {
            //Arrange
            var expected = 3;
            var grain = new Vegetable(3);
            _target.Eat(grain);
            //Act
            var actual = _target.FoodEaten;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Eat_InvalidInput_FoodEatenShouldBeNull()
        {
            //Arrange
            var expected = 0;
            var gooseEgg = new Meat(3);
            _target.Eat(gooseEgg);
            //Act
            var actual = _target.FoodEaten;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}