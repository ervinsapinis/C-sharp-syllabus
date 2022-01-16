using Xunit;
using DragRace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace.Tests
{
    public class IBoostableTests
    {
        private Mercedes _target = new Mercedes();

        [Fact()]
        public void StartEngine_ShouldReturnColdStartSound()
        {
            //Arrange
            var expected = "eeeeee BRRBRBRBRBRBRBRBR...";
            //Act
            var actual = _target.StartEngine();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void ShowCurrentSpeed_AtStart_ShouldReturn0()
        {
            //Arrange
            var expected = "0";
            //Act
            var actual = _target.ShowCurrentSpeed();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory()]
        [InlineData(1, "28")]
        [InlineData(2, "56")]
        [InlineData(4, "112")]
        [InlineData(10, "280")]
        public void ShowCurrentSpeed_AfterSpeedUpYTimes_ShouldReturn20xY(int times, string expected)
        {
            //Arrange
            for (int i = 0; i < times; i++)
            {
                _target.SpeedUp();
            }

            //Act
            var actual = _target.ShowCurrentSpeed();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory()]
        [InlineData(1, "25")]
        [InlineData(2, "50")]
        public void ShowCurrentSpeed_AfterUsingNO2_ShouldReturn25xY(int times, string expected)
        {
            //Arrange
            for (int i = 0; i < times; i++)
            {
                _target.UseNitrousOxideEngine();
            }

            //Act
            var actual = _target.ShowCurrentSpeed();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void ShowCurrentSpeed_AfterSpedUp2TimesAndSlowedDownOnce_ShouldReturn15()
        {
            //Arrange
            var expected = "36";
            _target.SpeedUp();
            _target.SpeedUp();
            _target.SlowDown();
            //Act
            var actual = _target.ShowCurrentSpeed();
            //Assert
            Assert.Equal(expected, actual);
        }
    }   
}