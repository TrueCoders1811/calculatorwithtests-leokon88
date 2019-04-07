using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithTests
{
    public class Calculator
    {
        public int TestAdd(int num1, int num2)
        {
            // throw new NotImplementedException();
            return num1 + num2;
        }
        public int TestSubtract(int num1, int num2)
        {
            throw new NotImplementedException();
        }
        public int TestMultiply(double num1, double num2)
        {
            throw new NotImplementedException();
        }
        public int TestDivide(double num1, double num2)
        {
            throw new NotImplementedException();
        }


        public int TestFactorial(int num1)
        {
            //Factorial is for non-negative numbers only
            //throw new NotImplementedException();
            int result = 1;
            if (num1>=0)
            {
                for (int i = 0; i < num1; i++)
                {
                    result  *= (num1 - i);
                }
            } return result;
        }
    }
}
