using System;

namespace MathUtils
{
	/// <summary>
	/// A set of common math functions not included in System.Math.
	/// </summary>
	public static class MathFunctions
	{
		/// <summary>
		/// Calculate the hypotenuse of a right triangle.
		/// </summary>
		/// <param name="x">First edge</param>
		/// <param name="y">Second edge</param>
		/// <returns>Third edge</returns>
		public static float Hypotenuse(int x, int y)
		{
			return Hypotenuse((float)x, (float)y);
		}

		/// <summary>
		/// Calculate the hypotenuse of a right triangle.
		/// </summary>
		/// <param name="x">First edge</param>
		/// <param name="y">Second edge</param>
		/// <returns>Third edge</returns>
		public static float Hypotenuse(float x, float y)
		{
			return (float)Hypotenuse((double)x, (double)y);
		}

		/// <summary>
		/// Calculate the hypotenuse of a right triangle.
		/// </summary>
		/// <param name="x">First edge</param>
		/// <param name="y">Second edge</param>
		/// <returns>Third edge</returns>
		public static double Hypotenuse(double x, double y)
		{
			return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
		}

		/// <summary>
		/// Calculate the average of a set of values.
		/// </summary>
		/// <param name="values">Values to average</param>
		/// <returns>Average of given values</returns>
		public static float Average(params int[] values)
		{
			int sum = 0;
			for (int i = 0; i < values.Length; i++)
				sum += values[i];

			return (float)sum / values.Length;
		}

		/// <summary>
		/// Calculate the average of a set of values.
		/// </summary>
		/// <param name="values">Values to average</param>
		/// <returns>Average of given values</returns>
		public static double Average(params long[] values)
		{
			long sum = 0;
			for (long i = 0; i < values.Length; i++)
				sum += values[i];

			return (float)sum / values.Length;
		}

		/// <summary>
		/// Calculate the average of a set of values.
		/// </summary>
		/// <param name="values">Values to average</param>
		/// <returns>Average of given values</returns>
		public static float Average(params float[] values)
		{
			float sum = 0;
			for (int i = 0; i < values.Length; i++)
				sum += values[i];

			return (float)sum / values.Length;
		}

		/// <summary>
		/// Calculate the average of a set of values.
		/// </summary>
		/// <param name="values">Values to average</param>
		/// <returns>Average of given values</returns>
		public static double Average(params double[] values)
		{
			double sum = 0;
			for (int i = 0; i < values.Length; i++)
				sum += values[i];

			return sum / values.Length;
		}

		/// <summary>
		/// Calculate the root mean square of a set of values.
		/// </summary>
		/// <param name="values">Values to calculate RMS</param>
		/// <returns>RMS of the given values</returns>
		public static double RootMeanSquare(params int[] values)
		{
			double value = 0;
			foreach (int i in values)
				value += Math.Pow(i, 2);

			return Math.Sqrt(value / values.Length);
		}

		/// <summary>
		/// Calculate the root mean square of a set of values.
		/// </summary>
		/// <param name="values">Values to calculate RMS</param>
		/// <returns>RMS of the given values</returns>
		public static double RootMeanSquare(params long[] values)
		{
			double value = 0;
			foreach (long i in values)
				value += Math.Pow(i, 2);

			return Math.Sqrt(value / values.Length);
		}

		/// <summary>
		/// Calculate the root mean square of a set of values.
		/// </summary>
		/// <param name="values">Values to calculate RMS</param>
		/// <returns>RMS of the given values</returns>
		public static double RootMeanSquare(params float[] values)
		{
			double value = 0;
			foreach (float i in values)
				value += Math.Pow(i, 2);

			return Math.Sqrt(value / values.Length);
		}

		/// <summary>
		/// Calculate the root mean square of a set of values.
		/// </summary>
		/// <param name="values">Values to calculate RMS</param>
		/// <returns>RMS of the given values</returns>
		public static double RootMeanSquare(params double[] values)
		{
			double value = 0;
			foreach (double i in values)
				value += Math.Pow(i, 2);

			return Math.Sqrt(value / values.Length);
		}
	}
}
