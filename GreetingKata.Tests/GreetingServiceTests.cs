using Xunit;
using GreetingKata;

namespace GreetingKata.Tests
{
    public class GreetingServiceTests
    {
        [Fact]
        public void Greet_ReturnsGreetingWithName()
        {
            // Arrange
            var greetingService = new GreetingService();
            var name = "Bel Maschione";

            // Act
            var result = greetingService.Greet(name);

            // Assert
            Assert.Equal("Hello, Bel Maschione.", result);
        }
    }
}
