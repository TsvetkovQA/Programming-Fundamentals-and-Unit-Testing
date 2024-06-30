using NUnit.Framework;
using System;
using System.Linq;

namespace TestApp.UnitTests
{
    public class DuplicatesTests
    {
        [Test]
        public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] numbers = Array.Empty<int>();

            // Act
            int[] result = Duplicates.RemoveDuplicates(numbers);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
        {
            // Arrange
            int[] numbers = new[] { 1, 2, 3, 4, 5 };

            // Act
            int[] result = Duplicates.RemoveDuplicates(numbers);

            // Assert
            Assert.That(result, Is.EqualTo(numbers));
        }

        [Test]
        public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
        {
            // Arrange
            int[] numbers = new[] { 1, 2, 2, 3, 4, 4, 5 };
            int[] expected = new[] { 1, 2, 3, 4, 5 };

            // Act
            int[] result = Duplicates.RemoveDuplicates(numbers);

            // Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
        {
            // Arrange
            int[] numbers = new[] { 1, 1, 1, 1 };
            int[] expected = new[] { 1 };

            // Act
            int[] result = Duplicates.RemoveDuplicates(numbers);

            // Assert
            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}
