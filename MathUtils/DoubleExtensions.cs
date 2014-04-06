using System;

namespace MathUtils
{
	public static class DoubleExtensions
	{
		/// <summary>
		/// Round a double down to the nearest integer
		/// </summary>
		/// <returns>This double, rounded down to the nearest equal or lesser integer</returns>
		public static int FloorToInt(this double val)
		{
			return (int)Math.Floor(val);
		}

		/// <summary>
		/// Round a float to the nearest integer
		/// </summary>
		/// <returns>This float, rounded to the nearest integer</returns>
		public static int RoundToInt(this double val)
		{
			return (int)Math.Round(val);
		}

		/// <summary>
		/// Round a float up to the nearest integer
		/// </summary>
		/// <returns>This float, rounded up to the nearest equal or greater integer</returns>
		public static int CeilToInt(this double val)
		{
			return (int)Math.Ceiling(val);
		}

		/// <summary>
		/// Round a double down to the nearest integer
		/// </summary>
		/// <returns>This double, rounded down to the nearest equal or lesser integer</returns>
		public static int FloorToLong(this double val)
		{
			return (int)Math.Floor(val);
		}

		/// <summary>
		/// Round a float to the nearest integer
		/// </summary>
		/// <returns>This float, rounded to the nearest integer</returns>
		public static int RoundToLong(this double val)
		{
			return (int)Math.Round(val);
		}

		/// <summary>
		/// Round a float up to the nearest integer
		/// </summary>
		/// <returns>This float, rounded up to the nearest equal or greater integer</returns>
		public static int CeilToLong(this double val)
		{
			return (int)Math.Ceiling(val);
		}

		/// <summary>
		/// Check if a double is within the given range inclusive
		/// </summary>
		/// <param name="min">Minimum value</param>
		/// <param name="max">Maximum value</param>
		/// <returns>True if this value is between min and max inclusive, false otherwise</returns>
		public static bool Between(this double val, double min, double max)
		{
			return val >= min && val <= max;
		}
	}
}
