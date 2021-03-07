using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
       ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Bhawesh Paliwal", returnValue.Value);
        }



        [Fact]
        public void Test1()
        {

        }

    }
}
