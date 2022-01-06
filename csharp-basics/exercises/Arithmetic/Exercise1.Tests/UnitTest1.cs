using System;
using Xunit;
using Excercise1;

namespace Exercise1.Tests
{
    public class UnitTest
    {
        [Theory]
        [InlineData(7, 8)]
        [InlineData(14, 1)]
        [InlineData(2, 13)]
        [InlineData(5, 10)]
        [InlineData(10, 5)]
        public void CheckIfFifteen_DifferentInputsToAdd_ShouldReturnTrue(int x, int y)
        {
            // Arrange
            bool expected = true;
            // Act
            bool actual = Excercise1.Program.CheckIfFifteen(x, y);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(23, 8)]
        [InlineData(14, 29)]
        [InlineData(2, 17)]
        [InlineData(25, 10)]
        [InlineData(120, 105)]
        public void CheckIfFifteen_DifferentInputsToSubtract_ShouldReturnTrue(int x, int y)
        {
            // Arrange
            bool expected = true;
            // Act
            bool actual = Excercise1.Program.CheckIfFifteen(x, y);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 8)]
        [InlineData(14, 15)]
        public void CheckIfFifteen_XOrYIs15_ShouldReturnTrue(int x, int y)
        {
            // Arrange
            bool expected = true;
            // Act
            bool actual = Excercise1.Program.CheckIfFifteen(x, y);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(231, 8)]
        [InlineData(124, 29)]
        [InlineData(2, 1)]
        [InlineData(25, 0)]
        [InlineData(120, 1095)]
        public void CheckIfFifteen_NeitherAre15andDontResultIn15_ShouldReturnTrue(int x, int y)
        {
            // Arrange
            bool expected = false;
            // Act
            bool actual = Excercise1.Program.CheckIfFifteen(x, y);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
