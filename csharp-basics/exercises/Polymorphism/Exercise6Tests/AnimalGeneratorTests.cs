using Xunit;
using Exercise6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6.Tests
{
    public class AnimalGeneratorTests
    {
        private AnimalGenerator _target = new AnimalGenerator();

        [Fact()]
        public void CreateAnimal_ValidInput_ShouldReturnTiger()
        {
            //Arrange
            var expected = new Tiger("testName", "tiger", 36, "testRegion");
            var name = "testName";
            var type = "tiger";
            var weight = 36;
            var region = "testRegion";
            //Act
            var actual = _target.CreateAnimal(type, name, weight, region);
            //Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Type, actual.Type);
            Assert.Equal(expected.Weight, actual.Weight);
            Assert.Equal(expected.LivingRegion, actual.LivingRegion);
        }

        [Fact()]
        public void CreateAnimal_ValidInput_ShouldReturnZebra()
        {
            //Arrange
            var expected = new Zebra("testName", "zebra", 99, "testRegion");
            var name = "testName";
            var type = "zebra";
            var weight = 99;
            var region = "testRegion";
            //Act
            var actual = _target.CreateAnimal(type, name, weight, region);
            //Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Type, actual.Type);
            Assert.Equal(expected.Weight, actual.Weight);
            Assert.Equal(expected.LivingRegion, actual.LivingRegion);
        }

        [Fact()]
        public void CreateAnimal_ValidInput_ShouldReturnMouse()
        {
            //Arrange
            var expected = new Mouse("testName", "mouse", 36, "testRegion");
            var name = "testName";
            var type = "mouse";
            var weight = 36;
            var region = "testRegion";
            //Act
            var actual = _target.CreateAnimal(type, name, weight, region);
            //Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Type, actual.Type);
            Assert.Equal(expected.Weight, actual.Weight);
            Assert.Equal(expected.LivingRegion, actual.LivingRegion);
        }

        [Fact()]
        public void CreateAnimal_InvalidInput_ShouldReturnError()
        {
            //Arrange
            var name = "testName";
            var type = "pig";
            var weight = 56;
            var region = "testRegion";
            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => _target.CreateAnimal(type, name, weight, region));
        }

        [Fact()]
        public void CreateCat_ValidInput_ShouldReturnCat()
        {
            //Arrange
            var expected = new Cat("testName", "cat", 36, "testRegion", "testBreed");
            var name = "testName";
            var type = "cat";
            var weight = 36;
            var region = "testRegion";
            var breed = "testBreed";
            //Act
            var actual = _target.CreateCat(type, name, weight, region, breed);
            //Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Type, actual.Type);
            Assert.Equal(expected.Weight, actual.Weight);
            Assert.Equal(expected.LivingRegion, actual.LivingRegion);
            Assert.Equal(expected.Breed, actual.Breed);
        }

        [Fact()]
        public void CreateCat_InvalidInput_ShouldThrowError()
        {
            //Arrange
            var name = "testName";
            var type = "ocelot";
            var weight = 36;
            var region = "testRegion";
            var breed = "testBreed";
            //Act
            //Assert
            Assert.Throws<ArgumentException>(() => _target.CreateCat(type, name, weight, region, breed));
        }
    }
}