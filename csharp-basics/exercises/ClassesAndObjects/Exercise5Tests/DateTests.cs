using Xunit;
using Exercise5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5.Tests
{
    public class DateTests
    {
        [Fact()]
        public void DisplayDate_22111993_ShouldReturn22111993()
        {
        //Arrange
        var expected = "22/11/1993";
        Date _target = new Date(22, 11, 1993);
        //Act
        var actual = _target.DisplayDate();
        //Arrange
        Assert.Equal(expected, actual);
        }
    }
}