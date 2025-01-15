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
    }
}
