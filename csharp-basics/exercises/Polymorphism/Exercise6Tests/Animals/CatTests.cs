using Xunit;
using Exercise6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6.Tests
{
    public class CatTests
    {
        private Cat _target = new("Muris", "Kakis", 5.6, "Majas", "Rizhiks");

        [Fact()]
        public void MakeSound_ShouldReturnMeow()
        {
            //Arrange
            var expected = "Meow.";
            //Act
            var actual = _target.MakeSound();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Eat_ValidInputVeg_ShouldIncrementFoodEaten()
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
        public void Eat_ValidInputMeat_ShouldIncrementFoodEaten()
        {
            //Arrange
            var expected = 5;
            var gooseEgg = new Meat(5);
            _target.Eat(gooseEgg);
            //Act
            var actual = _target.FoodEaten;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}