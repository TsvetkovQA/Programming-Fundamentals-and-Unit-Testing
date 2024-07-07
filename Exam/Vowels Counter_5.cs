using NUnit.Framework;  // Добавяме необходимите using директиви
using System.Collections.Generic;

namespace TestApp.Tests
{
    public class VowelsCounterTests
    {
        [Test]
        public void Test_CountTotalVowels_GetEmptyList_ReturnsZero()
        {
            // Arrange
            List<string> list = new List<string>();

            // Act
            int result = VowelsCounter.CountTotalVowels(list);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test_CountTotalVowels_GetListWithEmptyStringValues_ReturnsZero()
        {
            // Arrange
            List<string> list = new List<string> { "" };

            // Act
            int result = VowelsCounter.CountTotalVowels(list);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test_CountTotalVowels_MultipleLowerCaseStrings_ReturnsVowelsCount()
        {
            // Arrange
            List<string> list = new List<string> { "a", "e", "i", "b", "r"};

            // Act
            int result = VowelsCounter.CountTotalVowels(list);

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test_CountTotalVowels_GetStringsWithNoVowels_ReturnsZero()
        {
            // Arrange
            List<string> list = new List<string> { "b", "v", "s", "n" };
            int expected = 0;

            // Act
            int result = VowelsCounter.CountTotalVowels(list);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_CountTotalVowels_StringsWithMixedCaseVowels_ReturnsVowelsCount()
        {
            // Arrange
            List<string> list = new List<string> { "a", "e", "i", "O", "U" };

            // Act
            int result = VowelsCounter.CountTotalVowels(list);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
