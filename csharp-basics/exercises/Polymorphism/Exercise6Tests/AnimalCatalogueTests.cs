using Xunit;
using Exercise6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6.Tests
{
    public class AnimalCatalogueTests
    {
        AnimalCatalogue _target = new AnimalCatalogue();

        [Fact()]
        public void ValidAnimalInput_ValidInput_ShouldReturnTrue()
        {
            //Arrange
            var input = "cat";
            //Act
            //Assert
            Assert.True(_target.ValidAnimalInput(input));
        }

        [Fact()]
        public void ValidAnimalInput_inValidInput_ShouldReturnFalse()
        {
            //Arrange
            var input = "dog";
            //Act
            //Assert
            Assert.False(_target.ValidAnimalInput(input));
        }

        [Fact()]
        public void ShowAnimalChoices_ShouldReturnStringOfAnimals()
        {
            //Arrange
            var expected= "cat\ntiger\nzebra\nmouse\n";
            //Act
            var actual = _target.ShowAnimalChoices();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void ShowAnimalInfo_ShouldReturnString()
        {
            //Arrange
            var expected = "mouse[Mikijs, 5, lauki, 3]\n";
            var testFace = new Mouse("Mikijs", "mouse", 5, "lauki");
            var grain = new Vegetable(3);
            testFace.Eat(grain);
            _target.animalList.Add(testFace);

            //Act
            var actual = _target.ShowAnimalInfo();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}