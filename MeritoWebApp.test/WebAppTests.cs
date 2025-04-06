using Xunit;

namespace MeritoWebApp.test;

public class WebAppTests
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
}

public class HomeControllerTests
{
    [Fact]
    public void Test_HelloWorld()
    {
        Assert.Equal("Hello World!", "Hello World!");
    }
}