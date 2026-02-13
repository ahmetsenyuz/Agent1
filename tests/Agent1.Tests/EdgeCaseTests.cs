using System;
using Xunit;

namespace Agent1.Tests
{
    public class EdgeCaseTests
    {
        [Fact]
        public void TestMinimumValidInput_ReturnsOutput()
        {
            // Arrange
            int input = 1;
            
            // Act & Assert - Should not throw exception for minimum valid input
            Assert.DoesNotThrow(() => Program.Main(new string[] { input.ToString() }));
        }

        [Fact]
        public void TestMaximumAllowedInput_ReturnsOutput()
        {
            // Arrange
            int input = 1000000; // Maximum allowed iterations
            
            // Act & Assert - Should not throw exception for maximum allowed input
            Assert.DoesNotThrow(() => Program.Main(new string[] { input.ToString() }));
        }

        [Fact]
        public void TestLargeInput_ExceedsLimit()
        {
            // Arrange
            int input = 1000001; // Exceeds maximum iterations
            
            // Act & Assert
            Assert.Throws<OverflowException>(() => Program.Main(new string[] { input.ToString() }));
        }

        [Fact]
        public void TestEmptyStringInput_ThrowsFormatException()
        {
            // Arrange
            string input = "";
            
            // Act & Assert
            Assert.Throws<FormatException>(() => Program.Main(new string[] { input }));
        }

        [Fact]
        public void TestNullInput_ThrowsArgumentNullException()
        {
            // Arrange
            string[] input = null;
            
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => Program.Main(input));
        }
    }
}