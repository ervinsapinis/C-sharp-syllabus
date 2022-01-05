using Xunit;
using CalculateArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea.Tests
{
    public class GeometryTests
    {
        [Fact()]
        public void AreaOfCircle_5_ShouldReturn78p54()
        {
            //Arrange
            var expected = 78.54;
            //Act
            var actual = Geometry.AreaOfCircle(5);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void AreaOfRectangle_5n10_ShouldReturn50()
        {
            //Arrange
            var expected = 50;
            //Act
            var actual = Geometry.AreaOfRectangle(5, 10);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void AreaOfCircle_5n10_ShouldReturn25()
        {
            //Arrange
            var expected = 25;
            //Act
            var actual = Geometry.AreaOfTriangle(5, 10);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}