using System;
using System.IO;
using System.Text;
using Xunit;

namespace Agent1.Tests
{
    public class OutputGenerationTests
    {
        [Fact]
        public void TestOutputGeneration_ForValidInput()
        {
            // Arrange
            int input = 2;
            var originalOut = Console.Out;
            var stringBuilder = new StringBuilder();
            Console.SetOut(new StringWriter(stringBuilder));
            
            // Act
            Program.Main(new string[] { input.ToString() });
            
            // Reset console output
            Console.SetOut(originalOut);
            
            // Assert
            var output = stringBuilder.ToString();
            Assert.Contains("Iteration 1: Hello World", output);
            Assert.Contains("Iteration 2: Hello World", output);
        }

        [Fact]
        public void TestOutputGeneration_ExceedsMaximumIterations()
        {
            // Arrange
            int input = 1000001; // Exceeds max iterations
            var originalOut = Console.Out;
            var stringBuilder = new StringBuilder();
            Console.SetOut(new StringWriter(stringBuilder));
            
            // Act
            Program.Main(new string[] { input.ToString() });
            
            // Reset console output
            Console.SetOut(originalOut);
            
            // Assert
            var output = stringBuilder.ToString();
            Assert.Contains("Maximum iteration limit exceeded.", output);
        }
    }
}