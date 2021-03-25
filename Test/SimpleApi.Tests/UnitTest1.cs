using SimpleApi.Controllers;
using System;
using Xunit;

namespace SimpleApi.Tests
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController(null);
        [Fact]
        public void Test1()
        {
            var result = controller.Get();
            Assert.True(result != null);
        }
    }
}
