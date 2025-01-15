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
           
            var service = new GreetingService();

           
            var result = service.Greet("Bob");

            
            Assert.Equal("Hello, Bob.", result);
        }

        [Fact]
        public void Greet_ReturnsHelloMyFriend_WhenNameIsNull()
        {
         
            var service = new GreetingService();

           
            var result = service.Greet(null);

           
            Assert.Equal("Hello, my friend.", result);
        }
    }
}
