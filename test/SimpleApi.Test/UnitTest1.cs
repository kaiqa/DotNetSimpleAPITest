using System;
using Xunit;
using SimpleAPI.Controllers;
namespace SimpleApi.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void TestReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("kai qa",  returnValue.Value);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
