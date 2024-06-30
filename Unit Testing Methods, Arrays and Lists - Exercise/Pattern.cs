using NUnit.Framework;
using System;

namespace TestApp.UnitTests
{
    public class PatternTests
    {
        [Test]
        public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
        {
            // Arrange
            int[] inputArray = new[] { 1, 2, 1, 3, 4, 10, 12, 15 };
            int[] expectedArray = new[] { 1, 15, 2, 12, 3, 10, 4 };

            // Act
            int[] result = Pattern.SortInPattern(inputArray);

            // Assert
            Assert.That(result, Is.EqualTo(expectedArray));
        }

        [Test]
        public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] inputArray = Array.Empty<int>();

            // Act
            int[] result = Pattern.SortInPattern(inputArray);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
        {
            // Arrange
            int[] inputArray = new[] { 42 };
            int[] expectedArray = new[] { 42 };

            // Act
            int[] result = Pattern.SortInPattern(inputArray);

            // Assert
            Assert.That(result, Is.EqualTo(expectedArray));
        }

        [Test]
        public void Test_SortInPattern_ArrayWithDuplicates_RemovesDuplicatesAndSorts()
        {
            // Arrange
            int[] inputArray = new[] { 1, 3, 2, 2, 3, 1 };
            int[] expectedArray = new[] { 1, 3, 2 };

            // Act
            int[] result = Pattern.SortInPattern(inputArray);

            // Assert
            Assert.That(result, Is.EqualTo(expectedArray));
        }

        [Test]
        public void Test_SortInPattern_AllElementsSame_ReturnsSingleElementArray()
        {
            // Arrange
            int[] inputArray = new[] { 7, 7, 7, 7, 7 };
            int[] expectedArray = new[] { 7 };

            // Act
            int[] result = Pattern.SortInPattern(inputArray);

            // Assert
            Assert.That(result, Is.EqualTo(expectedArray));
        }
    }
}
