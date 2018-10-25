using System;
using Xunit;

namespace Audit.Tests
{
    public class StringUtilTests
    {
        [Fact]
        public void ThrowArgumentNullException_ValueIsNull()
        {
            // Arrange
            string value = null;
            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => value.Repeat(1));
        }

        [Fact]
        public void ThrowArgumentOutOfRangeException_CountIsNegative()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => "*".Repeat(-1));
        }

        [Fact]
        public void RepeatValue()
        {
            // Arrange
            // Act
            var repeated = "*".Repeat(3);
            // Assert
            Assert.Equal(3, repeated.Length);
            Assert.Equal("***", repeated);
        }
    }
}