using System;
using dotnetcoreApp.Controllers;
using Xunit;

namespace dotnetcoreApp.Tests
{
    public class UnitTest1
    {
        WeatherForecastController wfobj = new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            var test = wfobj.Get(101);
            Assert.Equal("Yukti Garg", test);
        
        }
    }
}
