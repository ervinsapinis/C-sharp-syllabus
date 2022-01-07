using Xunit;
using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Tests
{
    public class ProductTests
    {
        private Product _target = new Product("TestKit", 10.59, 6);

        [Fact()]
        public void PrintProduct_ShouldReturnProductInfo()
        {
            //Arrange
            var expected = "TestKit, price: 10.59 EUR, amount: 6 units";
            //Act
            var actual = _target.PrintProduct();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void ChangeQuantity_10_ShouldReturnAmount10()
        {
            //Arrange
            var expected = 10;
            //Act
            var actual = _target.ChangeQuantity(10);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void ChangeQuantity_0_ShouldReturnAmount0()
        {
            //Arrange
            var expected = 0;
            //Act
            var actual = _target.ChangeQuantity(0);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void ChangeQuantity_minus5_ShouldThrowException()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _target.ChangeQuantity(-5));
        }

        [Fact()]
        public void ChangePrice_20p99_ShouldReturn20p99()
        {
            //Arrange
            var expected = 20.99;
            //Act
            var actual = _target.ChangePrice(20.99);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void ChangePrice_0_ShouldThrowException()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _target.ChangePrice(0));
        }

        [Fact()]
        public void ChangePrice_minus10p99_ShouldThrowException()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _target.ChangePrice(-10.99));
        }
    }
}