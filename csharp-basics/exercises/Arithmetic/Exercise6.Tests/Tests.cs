using System;
using Xunit;
using Exercise6;

namespace Exercise6.Tests
{
    public class Tests
    {
        [Fact]
        public void Printer_3_ShouldReturnCoza()
        {
            // Arrange
            string expected = "Coza ";
            // Act
            string actual = CozaLozaWoza.Printer(3);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Printer_5_ShouldReturnLoza()
        {
            // Arrange
            string expected = "Loza ";
            // Act
            string actual = CozaLozaWoza.Printer(5);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Printer_7_ShouldReturnWoza()
        {
            // Arrange
            string expected = "Woza ";
            // Act
            string actual = CozaLozaWoza.Printer(7);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Printer_15_ShouldReturnCozaLoza()
        {
            // Arrange
            string expected = "CozaLoza ";
            // Act
            string actual = CozaLozaWoza.Printer(15);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Printer_105_ShouldReturnCozaLozaWoza()
        {
            // Arrange
            string expected = "CozaLozaWoza ";
            // Act
            string actual = CozaLozaWoza.Printer(105);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Printer_35_ShouldReturnLozaWoza()
        {
            // Arrange
            string expected = "LozaWoza ";
            // Act
            string actual = CozaLozaWoza.Printer(35);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Printer_21_ShouldReturnCozaWoza()
        {
            // Arrange
            string expected = "CozaWoza ";
            // Act
            string actual = CozaLozaWoza.Printer(21);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Printer_33_ShouldPrintNewLineAndPrintCoza()
        {
            // Arrange
            string expected = "Coza \n";
            // Act
            string actual = CozaLozaWoza.Printer(33);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(22)]
        [InlineData(88)]
        [InlineData(44)]
        [InlineData(11)]
        public void Printer_VariousIntegersThatAreNotDivisibleBy3Or5Or7_ShouldPrintSameIntegerAndNewLine(int x)
        {
            // Arrange
            string expected = $"{x} \n";
            // Act
            string actual = CozaLozaWoza.Printer(x);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(26)]
        [InlineData(16)]
        [InlineData(47)]
        [InlineData(74)]
        [InlineData(8)]
        public void Printer_VariousIntegersThatAreNotDivisibleBy3Or5Or7_ShouldPrintSameInteger(int x)
        {
            // Arrange
            string expected = $"{x} ";
            // Act
            string actual = CozaLozaWoza.Printer(x);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
