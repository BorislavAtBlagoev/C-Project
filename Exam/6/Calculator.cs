
using System;

namespace _6
{
    public class Calculator
    {
        public int Operation(int firstNumber, int secondNumber, string operationSign)
        {
            int result = 0;

            switch (operationSign)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (firstNumber == 0 || secondNumber == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Invalid operation");
            }

            return result;
        }
    }
}
