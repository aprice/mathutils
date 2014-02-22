using System;

namespace MathUtils
{
	public static class MathFunctions
	{
		public static Int32 Hypotenuse(Int32 x, Int32 y)
		{
			return (Hypotenuse((double)x, (double)y)).RoundToInt();
		}

		public static Single Hypotenuse(Single x, Single y)
		{
			return (Single)Hypotenuse((double)x, (double)y);
		}

		public static Double Hypotenuse(Double x, Double y)
		{
			return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
		}

		public static Single Average(params int[] values)
		{
			int sum = 0;
			for (int i = 0; i < values.Length; i++)
				sum += values[i];

			return (float)sum / values.Length;
		}

		public static Single Average(params float[] values)
		{
			float sum = 0;
			for (int i = 0; i < values.Length; i++)
				sum += values[i];

			return (float)sum / values.Length;
		}

		public static Double Average(params double[] values)
		{
			double sum = 0;
			for (int i = 0; i < values.Length; i++)
				sum += values[i];

			return sum / values.Length;
		}
	}
}
