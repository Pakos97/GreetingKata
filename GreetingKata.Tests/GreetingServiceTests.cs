public class GreetingServiceTests
{
    [Fact]
    public void Greet_ReturnsHelloMyFriend_WhenNameIsNull()
    {
        var service = new GreetingService();
        var result = service.GreetMultiple(new string[] { null });
        Assert.Equal("Hello, my friend.", result);
    }

    [Fact]
    public void Greet_ReturnsShouting_WhenNameIsUppercase()
    {
        var service = new GreetingService();
        var result = service.GreetMultiple(new string[] { "JERRY" });
        Assert.Equal("HELLO JERRY!", result);
    }

    [Fact]
    public void Greet_ReturnsHelloWithName()
    {
        var service = new GreetingService();
        var result = service.GreetMultiple(new string[] { "Bob" });
        Assert.Equal("Hello, Bob.", result);
    }

    [Fact]
    public void GreetMultiple_ReturnsHelloWithTwoNames()
    {
        var service = new GreetingService();
        var result = service.GreetMultiple(new string[] { "Amy", "Brian" });
        Assert.Equal("Hello, Amy and Brian.", result);
    }

    [Fact]
    public void GreetMultiple_ReturnsHelloWithMultipleNames()
    {
        var service = new GreetingService();
        var result = service.GreetMultiple(new string[] { "Amy", "Brian", "Charlotte" });
        Assert.Equal("Hello, Amy, Brian, and Charlotte.", result);
    }

    [Fact]
    public void GreetMultiple_ReturnsSeparateGreetingsForNormalAndShoutedNames()
    {
        var service = new GreetingService();
        var result = service.GreetMultiple(new string[] { "Amy", "BRIAN", "Charlotte" });
        Assert.Equal("Hello, Amy and Charlotte. HELLO BRIAN!", result);
    }

    [Fact]
    public void GreetMultiple_ReturnsHelloWithEscapedNames()
    {
        var service = new GreetingService();
        var result = service.GreetMultiple(new string[] { "Bob", "\"Charlie, Dianne\"" });
        Assert.Equal("Hello, Bob and Charlie, Dianne.", result);
    }

    [Fact]
    public void GreetMultiple_ReturnsHelloWithCommaSeparatedNames()
    {
        var service = new GreetingService();
        var result = service.GreetMultiple(new string[] { "Bob", "Charlie, Dianne" });
        Assert.Equal("Hello, Bob, Charlie, and Dianne.", result);
    }
}
