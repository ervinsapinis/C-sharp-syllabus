using Xunit;
using DragRace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace.Tests
{
    public class ICarTests
    {
        private Audi _target = new Audi();

        [Fact()]
        public void StartEngine_ShouldReturnColdStartSound()
        {
            //Arrange
            var expected = "Rrrrrrr.....";
            //Act
            var actual = _target.StartEngine();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Show_currentSpeed_AtStart_ShouldReturn0()
        {
            //Arrange
            var expected = "0";
            //Act
            var actual = _target.Show_currentSpeed();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory()]
        [InlineData(1, "15")]
        [InlineData(2, "30")]
        [InlineData(4, "60")]
        [InlineData(10, "150")]
        public void Show_currentSpeed_AfterSpeedUpYTimes_ShouldReturn15xY(int times, string expected)
        {
            //Arrange
            var actual = string.Empty;
            for (int i = 0; i < times; i++)
            {
                _target.SpeedUp();
            }

            //Act
            actual = _target.Show_currentSpeed();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Show_currentSpeed_AfterSpedUp2TimesAndSlowedDownOnce_ShouldReturn15()
        {
            //Arrange
            var expected = "15";
            _target.SpeedUp();
            _target.SpeedUp();
            _target.SlowDown();
            //Act
            var actual = _target.Show_currentSpeed();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}