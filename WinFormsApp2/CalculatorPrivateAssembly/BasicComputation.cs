﻿namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }
}
