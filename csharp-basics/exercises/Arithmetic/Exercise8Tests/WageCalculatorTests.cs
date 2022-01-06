using Xunit;
using Exercise8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8.Tests
{
    public class WageCalculatorTests
    {
        [Fact()]
        public void TotalPay_BelowMinWage_ShouldReturnError()
        {
            //Arrange
            string expected = "Error: base pay cannot be less than $8.00 per hour!";
            //Act
            string actual = WageCalculator.TotalPay(7.50, 35);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void TotalPay_AboveMaxHours_ShouldReturnError()
        {
            //Arrange
            string expected = "Error: employees may not work more than 60h per week!";
            //Act
            string actual = WageCalculator.TotalPay(8, 65);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void TotalPay_ValidInput_ShouldReturnPay()
        {
            //Arrange
            string expected = "Your total pay is: $320";
            //Act
            string actual = WageCalculator.TotalPay(8, 40);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void TotalPay_ValidInput_ShouldReturnPayPlusOverTime()
        {
            //Arrange
            string expected = "Your total pay is: $550";
            //Act
            string actual = WageCalculator.TotalPay(10, 50);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}