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

        [Theory]
        [InlineData(8,3,5)]
        [InlineData(-1, -1, 0)]
        [InlineData(4, -3, 7)]
        public void TestForSubtractMethod(int num1, int num2, int expectedValue)
        { 
            Calculator calc = new Calculator();
            //Arrange
            int actualResult = calc.TestSubtract(num1, num2);
            //Act
            Assert.Equal(expectedValue, actualResult);
            //Assert
         }

        [Theory]
        [InlineData(4,5,20)]
        [InlineData(-4, 1, -4)]
        [InlineData(5, 2, 2.5)]
        public void TestMultiply(double num1, double num2, double expectedValue)
        {
            Calculator cal = new Calculator();
            //Arrange
            double actualResult = cal.TestMultiply(num1,num2);
            //Act
            Assert.Equal(expectedValue, actualResult);
            //Assert
        }

        [Theory]
        [InlineData(1.0,4,0.25)]
        [InlineData(-13.0,4,3.25)]
        [InlineData(0, 0, 0)]
        public void TestDivide(double num1, double num2, double expectedValue)
        {
            Calculator calc = new Calculator();
            //Arrange
            double actualResult = calc.TestDivide(num1, num2);
            //Act
            Assert.Equal(expectedValue, actualResult);
            //Assert

        }

        [Theory]
        [InlineData(24, 4)]
        [InlineData(0,-4 )]
        [InlineData(720,6)]
        public void TestFactorial(int num1,  int expectedValue)
        {
            Calculator calc = new Calculator();
            //Arrange
            double actualResult = calc.TestFactorial(num1);
            //Act
            Assert.Equal(expectedValue, actualResult);
            //Assert

        }
    }
}
