using NUnit.Framework;

namespace TestApp.UnitTests
{
    public class PrimeFactorTests
    {
        [Test]
        public void Test_FindLargestPrimeFactor_PrimeNumber()
        {
            // Arrange
            long primeNumber = 13;

            // Act
            long result = PrimeFactor.FindLargestPrimeFactor(primeNumber);

            // Assert
            Assert.AreEqual(13, result);
        }

        [Test]
        public void Test_FindLargestPrimeFactor_LargeNumber()
        {
            // Arrange
            long largeNumber = 13195;

            // Act
            long result = PrimeFactor.FindLargestPrimeFactor(largeNumber);

            // Assert
            Assert.AreEqual(29, result);
        }

        [Test]
        public void Test_FindLargestPrimeFactor_NumberWithMultiplePrimeFactors()
        {
            // Arrange
            long number = 60; // Prime factors are 2, 3, 5

            // Act
            long result = PrimeFactor.FindLargestPrimeFactor(number);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Test_FindLargestPrimeFactor_SmallNumber()
        {
            // Arrange
            long smallNumber = 6; // Prime factors are 2 and 3

            // Act
            long result = PrimeFactor.FindLargestPrimeFactor(smallNumber);

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test_FindLargestPrimeFactor_NumberIsOne()
        {
            // Arrange
            long number = 1;

            // Act
            long result = PrimeFactor.FindLargestPrimeFactor(number);

            // Assert
            Assert.AreEqual(1, result); // 1 has no prime factors, so return 1
        }
    }
}
