using System;
using Xunit;
using Riimut;

namespace RiimutTest
{
    public class Riimut
    {
        [Fact]
        public void TestMethod_Returns_False()
        {
            Assert.False(Main.testMethod());
        }
    }
}
