using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests
{
    public class NumberProcessorTests
    {
        [Test]
        public void Test_ProcessNumbers_SquareEvenNumbers()
        {
            // Arrange
            List<int> input = new List<int> { 2, 4, 6 };
            List<double> expected = new List<double> { 4, 16, 36 };

            // Act
            List<double> actual = NumberProcessor.ProcessNumbers(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_ProcessNumbers_SquareRootOddNumbers()
        {
            // Arrange
            List<int> input = new List<int> { 1, 3, 5 };
            List<double> expected = new List<double> { 1, Math.Sqrt(3), Math.Sqrt(5) };

            // Act
            List<double> actual = NumberProcessor.ProcessNumbers(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_ProcessNumbers_HandleZero()
        {
            // Arrange
            List<int> input = new List<int> { 0 };
            List<double> expected = new List<double> { 0 };

            // Act
            List<double> actual = NumberProcessor.ProcessNumbers(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_ProcessNumbers_EmptyInput()
        {
            // Arrange
            List<int> input = new List<int>();
            List<double> expected = new List<double>();

            // Act
            List<double> actual = NumberProcessor.ProcessNumbers(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_ProcessNumbers_MixedNumbers()
        {
            // Arrange
            List<int> input = new List<int> { 0, 1, 2, 3, 4 };
            List<double> expected = new List<double> { 0, 1, 4, Math.Sqrt(3), 16 };

            // Act
            List<double> actual = NumberProcessor.ProcessNumbers(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
