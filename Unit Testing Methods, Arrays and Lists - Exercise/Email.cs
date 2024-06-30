using NUnit.Framework;

namespace TestApp.UnitTests
{
    public class EmailTests
    {
        [Test]
        public void Test_IsValidEmail_ValidEmail()
        {
            // Arrange
            string validEmail = "test@example.com";

            // Act
            bool result = Email.IsValidEmail(validEmail);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_IsValidEmail_InvalidEmail()
        {
            // Arrange
            string invalidEmail = "test@.com";

            // Act
            bool result = Email.IsValidEmail(invalidEmail);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_IsValidEmail_NullInput()
        {
            // Arrange
            string nullEmail = null;

            // Act
            bool result = Email.IsValidEmail(nullEmail);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_IsValidEmail_EmptyString()
        {
            // Arrange
            string emptyEmail = "";

            // Act
            bool result = Email.IsValidEmail(emptyEmail);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_IsValidEmail_WhiteSpaceString()
        {
            // Arrange
            string whiteSpaceEmail = "   ";

            // Act
            bool result = Email.IsValidEmail(whiteSpaceEmail);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_IsValidEmail_InvalidFormat()
        {
            // Arrange
            string invalidFormatEmail = "invalid-email";

            // Act
            bool result = Email.IsValidEmail(invalidFormatEmail);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
