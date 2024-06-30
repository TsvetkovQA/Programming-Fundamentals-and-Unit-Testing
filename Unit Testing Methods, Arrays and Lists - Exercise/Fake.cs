using NUnit.Framework;
using System;
using System.Linq;

namespace TestApp.UnitTests
{
    public class FakeTests
    {
        [Test]
        public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
        {
            // Arrange
            char[] inputArray = new[] { 'a', '1', 'b', '2', 'c', '3' };
            char[] expectedArray = new[] { 'a', 'b', 'c' };

            // Act
            char[] result = Fake.RemoveStringNumbers(inputArray);

            // Assert
            Assert.That(result, Is.EqualTo(expectedArray));
        }

        [Test]
        public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
        {
            // Arrange
            char[] inputArray = new[] { 'a', 'b', 'c' };

            // Act
            char[] result = Fake.RemoveStringNumbers(inputArray);

            // Assert
            Assert.That(result, Is.EqualTo(inputArray));
        }

        [Test]
        public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            char[] inputArray = Array.Empty<char>();

            // Act
            char[] result = Fake.RemoveStringNumbers(inputArray);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_RemoveStringNumbers_NullArray_ThrowsArgumentException()
        {
            // Arrange
            char[]? inputArray = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => Fake.RemoveStringNumbers(inputArray));
        }
    }
}
