using System;
using Xunit;

namespace Audit.Obfuscators.Tests
{
    public class PinObfuscatorTest
    {
        [Fact]
        public void ThrowArgumentNullException_Value()
        {
            // Arrange
            var obfuscator = new PinObfuscator();
            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => obfuscator.Obfuscate(null));
        }

        [Fact]
        public void ThrowArgumentOutOfRangeException_Value()
        {
            // Arrange
            const string pin = "20010101-ABCDE";
            var obfuscator = new PinObfuscator();
            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => obfuscator.Obfuscate(pin));
        }

        [Theory]
        [InlineData("010101-ABCD", "010101-****")]
        [InlineData("010101ABCD", "010101****")]
        [InlineData("20010101-ABCD", "20010101-****")]
        [InlineData("20010101ABCD", "20010101****")]
        public void ObfuscateEmail(
            string email,
            string expected)
        {
            // Arrange
            var obfuscator = new PinObfuscator();

            // Act
            var obfuscated = obfuscator.Obfuscate(email);

            // Assert
            Assert.Equal(expected, obfuscated);
        }
    }
}
