using System;
using Xunit;
using Excercise2;

namespace Exercise2.Tests
{
    public class Tests
    {
        [Fact]
        public void CheckValue_OddNum_ShouldReturnOdd()
        {
            // Arrange
            var expected = "Odd number";
            var x = 5;
            // Act
            var actual = CheckOddEven.CheckValue(x);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckValue_EvenNum_ShouldReturnEven()
        {
            // Arrange
            var expected = "Even number";
            var x = 2;
            // Act
            var actual = CheckOddEven.CheckValue(x);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ByeMessage_ShouldReturnBye()
        {
            // Arrange
            var expected = "Bye!";
            // Act
            var actual = CheckOddEven.ByeMessage();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
