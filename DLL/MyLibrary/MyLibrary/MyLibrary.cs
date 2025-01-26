﻿namespace MyProject
{
    public static class MyLibrary
    {
        public static double Add(double a, double b)
		{
			return a + b;
		}

		public static double Subtract(double a, double b)
		{
			return a - b;
		}

		public static double Multiply(double a, double b)
		{
			return a * b;
		}

		public static double Divide(double a, double b)
		{
			if (b == 0)
			{
				throw new System.ArgumentException("Cannot divide by zero", "b");
			}
			return a / b;
		}
	} 
}
