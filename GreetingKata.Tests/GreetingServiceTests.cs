using System;
using Xunit;
using GreetingKata;

namespace GreetingKata.Tests
{
    public class GreetingServiceTests
    {
        [Fact]
        public void Greet_ReturnsHelloWithName()
        {
            // Arrange
            var service = new GreetingService();

            // Act
            var result = service.Greet("Bob");

            // Assert
            Assert.Equal("Hello, Bob.", result);
        }

        [Fact]
        public void Greet_ReturnsHelloMyFriend_WhenNameIsNull()
        {
            // Arrange
            var service = new GreetingService();

            // Act
            var result = service.Greet(null);

            // Assert
            Assert.Equal("Hello, my friend.", result);
        }

        [Fact]
        public void Greet_ReturnsShouting_WhenNameIsUppercase()
        {
            // Arrange
            var service = new GreetingService();

            // Act
            var result = service.Greet("JERRY");

            // Assert
            Assert.Equal("HELLO JERRY!", result);
        }

        [Fact]
        public void GreetMultiple_ReturnsHelloWithTwoNames()
        {
            // Arrange
            var service = new GreetingService();

            // Act
            var result = service.GreetMultiple(new string[] { "Jill", "Jane" });

            // Assert
            Assert.Equal("Hello, Jill and Jane.", result);
        }

        [Fact]
        public void GreetMultiple_ReturnsHelloWithMultipleNames()
        {
            // Arrange
            var service = new GreetingService();

            // Act
            var result = service.GreetMultiple(new string[] { "Amy", "Brian", "Charlotte" });

            // Assert
            Assert.Equal("Hello, Amy, Brian, and Charlotte.", result);
        }

        [Fact]
        public void GreetMultiple_ReturnsSeparateGreetingsForNormalAndShoutedNames()
        {
            // Arrange
            var service = new GreetingService();

            // Act
            var result = service.GreetMultiple(new string[] { "Amy", "BRIAN", "Charlotte" });

            // Assert
            Assert.Equal("Hello, Amy and Charlotte. AND HELLO BRIAN!", result);
        }

        [Fact]
        public void GreetMultiple_ReturnsHelloWithCommaSeparatedNames()
        {
            // Arrange
            var service = new GreetingService();

            // Act
            var result = service.GreetMultiple(new string[] { "Bob", "Charlie, Dianne" });

            // Assert
            Assert.Equal("Hello, Bob, Charlie, and Dianne.", result);
        }

    }
}
