using Xunit;
using WordCount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Tests
{
    public class WordCountTests
    {
        public WordCount _target = new WordCount(@"D:\codelex\mans repository\C-sharp-syllabus\csharp-basics\exercises\Collections\WordCount\lear.txt"); // nācās rakstīt pilno directory, citādi lasīja no testa mapes.

        [Fact()]
        public void FileText_ShouldReturnTextInDirectory()
        {
            //Arrange
            var expected = System.IO.File.ReadAllText(@"D:\codelex\mans repository\C-sharp-syllabus\csharp-basics\exercises\Collections\WordCount\lear.txt");
            //Act
            var actual = _target.FileText();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CountOfLines_ShouldReturn6()
        {
            //Arrange
            var expected = 6;
            //Act
            var actual = _target.CountOfLines(); 
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CountOfWords_ShouldReturn47()
        {
            //Arrange
            var expected = 47;
            //Act
            var actual = _target.CountOfWords();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CountOfChars_ShouldReturn247()
        {
            //Arrange
            var expected = 247;
            //Act
            var actual = _target.CountOfChars();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}