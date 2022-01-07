using Xunit;
using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Tests
{
    public class PhoneDirectoryTests
    { 
        PhoneDirectory _target = new PhoneDirectory();
        
        [Fact()]
        public void FindNumber_ValidInput_ShouldReturnNumber()
        {
            //Arrange
            _target.AddEntry("Phil Biggs", "906-346-4956");
            var expected = "The number 906-346-4956 is under the name Phil Biggs";
            //Act
            var actual = _target.FindNumber("906-346-4956");
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void FindName_ValidInput_ShouldReturnName()
        {
            //Arrange
            _target.AddEntry("Phil Biggs", "906-346-4956");
            var expected = "The name Phil Biggs is under the Phonebook entry 906-346-4956";
            //Act
            var actual = _target.FindName("Phil Biggs");
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void AddEntry_ValidInputs_ShouldAddToDict()
        {
            //Arrange
            //Act
            _target.AddEntry("Smeagol Gollum", "123-riverfolk-456");
            //Assert
            Assert.True(_target.PhoneEntryDictionary.ContainsKey("Smeagol Gollum"));
            Assert.True(_target.PhoneEntryDictionary.ContainsValue("123-riverfolk-456"));
        }

        [Fact()]
        public void AddEntry_OnlyName_ShouldReturnException()
        {
            //Assert
            Assert.Throws<Exception>(() => _target.AddEntry("Robert", null));
        }

        [Fact()]
        public void AddEntry_OnlyNumber_ShouldReturnException()
        {
            //Assert
            Assert.Throws<Exception>(() => _target.AddEntry(null, "111-222-333-54"));
        }
    }
}