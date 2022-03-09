using System;
using System.Collections.Generic;
using Xunit;



namespace TestProject1
{
    //Empty string return 0
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(0, StringSomething.StringCalculator.SumString(""));
            Assert.Equal(0, StringSomething.StringCalculator.SumString("1"));
        }



    }
}
