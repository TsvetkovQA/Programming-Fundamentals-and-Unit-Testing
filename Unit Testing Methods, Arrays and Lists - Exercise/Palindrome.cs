using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests
{
    public class PalindromeTests
    {
        [Test]
        public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            // Arrange
            List<string> words = new() { "level", "radar", "civic" };

            // Act
            bool result = Palindrome.IsPalindrome(words);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_IsPalindrome_EmptyList_ReturnsTrue()
        {
            // Arrange
            List<string> words = new();

            // Act
            bool result = Palindrome.IsPalindrome(words);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_IsPalindrome_SingleWord_ReturnsTrue()
        {
            // Arrange
            List<string> words = new() { "level" };

            // Act
            bool result = Palindrome.IsPalindrome(words);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
        {
            // Arrange
            List<string> words = new() { "hello", "world" };

            // Act
            bool result = Palindrome.IsPalindrome(words);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
        {
            // Arrange
            List<string> words = new() { "Level", "Radar", "Civic" };

            // Act
            bool result = Palindrome.IsPalindrome(words);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_IsPalindrome_SingleNonPalindrome_ReturnsFalse()
        {
            // Arrange
            List<string> words = new() { "example" };

            // Act
            bool result = Palindrome.IsPalindrome(words);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
