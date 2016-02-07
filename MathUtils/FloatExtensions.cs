using System;

namespace MathUtils
{
	/// <summary>
	/// General utility extensions to System.Single
	/// </summary>
	public static class FloatExtensions
	{
		/// <summary>
		/// Clamp a float between two values
		/// </summary>
		/// <param name="min">Minimum value</param>
		/// <param name="max">Maximum value</param>
		/// <returns>This float's value, but no less than min, and no more than max</returns>
		public static float Clamp(this float val, float min, float max)
		{
			return Math.Max(min, Math.Min(val, max));
		}

		/// <summary>
		/// Round a float down to the nearest integer
		/// </summary>
		/// <returns>This float, rounded down to the nearest equal or lesser integer</returns>
		public static int FloorToInt(this float val)
		{
			return (int)Math.Floor(val);
		}

		/// <summary>
		/// Round a float to the nearest integer
		/// </summary>
		/// <returns>This float, rounded to the nearest integer</returns>
		public static int RoundToInt(this float val)
		{
			return (int)Math.Round(val);
		}

		/// <summary>
		/// Round a float up to the nearest integer
		/// </summary>
		/// <returns>This float, rounded up to the nearest equal or greater integer</returns>
		public static int CeilToInt(this float val)
		{
			return (int)Math.Ceiling(val);
		}

		/// <summary>
		/// Check if a float is within the given range inclusive
		/// </summary>
		/// <param name="min">Minimum value</param>
		/// <param name="max">Maximum value</param>
		/// <returns>True if this value is between min and max inclusive, false otherwise</returns>
		public static bool Between(this float val, float min, float max)
		{
			if (min > max)
				return val.Between(max, min);
			else
				return val >= min && val <= max;
		}
	}
}
