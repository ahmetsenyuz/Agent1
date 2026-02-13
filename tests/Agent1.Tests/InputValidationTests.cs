using System;
using Xunit;

namespace Agent1.Tests
{
    public class InputValidationTests
    {
        [Fact]
        public void TestZeroInput_ReturnsNoOutput()
        {
            // Arrange
            int input = 0;
            
            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.Main(new string[] { input.ToString() }));
        }

        [Fact]
        public void TestNegativeInput_ReturnsError()
        {
            // Arrange
            int input = -5;
            
            // Act & Assert
            Assert.Throws<ArgumentException>(() => Program.Main(new string[] { input.ToString() }));
        }

        [Fact]
        public void TestValidPositiveInput_ReturnsSuccess()
        {
            // Arrange
            int input = 3;
            
            // Act & Assert - Should not throw exception for valid input
            Assert.DoesNotThrow(() => Program.Main(new string[] { input.ToString() }));
        }

        [Fact]
        public void TestInvalidInput_ThrowsFormatException()
        {
            // Arrange
            string input = "invalid";
            
            // Act & Assert
            Assert.Throws<FormatException>(() => Program.Main(new string[] { input }));
        }
    }
}