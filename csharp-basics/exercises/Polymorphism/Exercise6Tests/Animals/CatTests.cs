using Xunit;
using Exercise6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6.Tests
{
    public class CatTests : UserInput
    {
        private string[] _output = new string[] {"meat", "3", "asd", "5", "vegetable"};
        private int _index = 0;
        public override string Read()
        {
            return _output[_index++];
        }

        private Cat _target = new Cat("Muris", "Kakis", 3.5, "Lauki", "Latgales resnais");
        private AnimalFeeder _targetFeeder = new AnimalFeeder();

        [Fact()]
        public void MakeSound_ShouldReturnSound()
        {
            //Arrange
            var expected = "Meow.";
            //Act
            var actual = _target.MakeSound();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void FeedAnimal_ValidFoodAndAmount_ShouldAddToFoodCounter()
        {
            //Arrange
            var expected = 3;
            _target.Eat(_targetFeeder.FeedAnimal());
            //Act
             var actual = _target.FoodEaten;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void FeedAnimal_InvalidFoodThenValidAmountAndFood_ShouldAddToFoodCounter()
        {
            //Arrange
            var expected = 5;
            _target.Eat(_targetFeeder.FeedAnimal());
            //Act
            var actual = _target.FoodEaten;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}