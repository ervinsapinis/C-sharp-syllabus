using Xunit;
using GravityCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityCalculator.Tests
{
    public class EarthGravityCalculatorTests
    {
        [Fact()]
        public void Calculate_StandstillObjectFalling10sec_m490p5()
        {
            // Arrange
            var expected = "The object's position after 10 seconds is -490.5 m.";
            var earth = new EarthGravityCalculator(0, 10, 0);
            // Act
            var actual = earth.ReportResult();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}