using System;
using Xunit;

namespace Audit.Obfuscators.Tests
{
    public class EmailObfuscatorTest
    {
        [Fact]
        public void ThrowArgumentNullExceptionWhenArgumentIsNull()
        {
            // Arrange
            var obfuscator = new EmailObfuscator();
            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => obfuscator.Obfuscate(null));
        }

        [Theory]
        [InlineData("mediumlongemail@somedomain.net", "m*************l@somedomain.net")]
        public void ObfuscateEmail(
            string email,
            string expected)
        {
            // Arrange
            var obfuscator = new EmailObfuscator();

            // Act
            var obfuscated = obfuscator.Obfuscate(email);

            // Assert
            Assert.Equal(expected, obfuscated);
        }
    }
}
