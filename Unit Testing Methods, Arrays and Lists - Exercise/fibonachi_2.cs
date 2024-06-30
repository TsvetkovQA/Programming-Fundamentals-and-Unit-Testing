using NUnit.Framework;
using TestApp;

namespace TestApp.UnitTests
{
    public class FibonacciTests
    {
        [Test]
        public void Test_CalculateFibonacci_ZeroInput()
        {
            // Arrange
            int input = 0;
            int expectedOutput = 0;

            // Act
            int actualOutput = Fibonacci.CalculateFibonacci(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_CalculateFibonacci_OneInput()
        {
            // Arrange
            int input = 1;
            int expectedOutput = 1;

            // Act
            int actualOutput = Fibonacci.CalculateFibonacci(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_CalculateFibonacci_PositiveInput()
        {
            // Arrange & Act & Assert for multiple inputs
            Assert.AreEqual(1, Fibonacci.CalculateFibonacci(2));
            Assert.AreEqual(2, Fibonacci.CalculateFibonacci(3));
            Assert.AreEqual(3, Fibonacci.CalculateFibonacci(4));
            Assert.AreEqual(5, Fibonacci.CalculateFibonacci(5));
            Assert.AreEqual(8, Fibonacci.CalculateFibonacci(6));
            Assert.AreEqual(13, Fibonacci.CalculateFibonacci(7));
            Assert.AreEqual(55, Fibonacci.CalculateFibonacci(10));
        }
    }
}
