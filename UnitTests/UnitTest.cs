using FluentAssertions;
using LetsKube;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace UnitTests
{
    public class UnitTest
    {
        [Fact]
        public void Test()
        {
            // Arrange
            var startup = new Startup();
            var expectedResult = 1;

            // Action
            var result = 1;
            startup.ConfigureServices(new ServiceCollection());

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var startup = new Startup();
            var expectedResult = 3;

            // Action
            var result = 1;
            startup.ConfigureServices(new ServiceCollection());

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}