using System;
using Xunit;
using Exercise1;

namespace Exercise1.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData()]
        public void Test1()
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = Check
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
