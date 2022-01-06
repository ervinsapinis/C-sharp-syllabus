using Xunit;
using Exercise6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6.Tests
{
    public class MakeArraysTests
    {
        [Fact()]
        public void CreateEmptyArrayOf10_ShouldReturnNewEmptyIntArrOf10()
        {
            //Arrange
            var expected = new int[10];
            //Act
            var actual = MakeArrays.CreateEmptyArrayOf10();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void FillArr_ShouldFillEmptyArrayWithRandomIntegersInRangeof0to100()
        {
            //Arrange
            var testArr = new int[10];
            MakeArrays.FillArr(testArr);
            //Assert
            for (int i = 0; i < testArr.Length; i++)
            {
                Assert.InRange(testArr[i], 1, 100);
            }
        }

        [Fact()]
        public void CopyArrAndReplaceLastElementTest()
        {
            //Arrange
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -7, };
            var arr = new int[10];
            MakeArrays.FillArr(arr);
            //Act
            var actual = MakeArrays.CopyArrAndReplaceLastElement(arr);
            //Assert
            Assert.Equal(expected[^1], actual[^1]);
        }
    }
}