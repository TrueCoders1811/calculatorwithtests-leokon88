using CalculatorWithTests;
using System;
using Xunit;

namespace TestApplication.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2 ,3)]
        [InlineData(5, 2, 7)]
        [InlineData(-2, -2, 0)]
        [InlineData(0, 0, 0)]

        public void TestForAddMethod(int num1, int num2, int expectedValue)
        {
            Calculator calc = new Calculator();
            //Arange
           int actualResult= calc.TestAdd(num1, num2);
            //Act
            Assert.Equal(expectedValue, actualResult);
            //Assert
        }
    }
}
