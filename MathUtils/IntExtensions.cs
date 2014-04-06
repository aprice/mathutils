using System;

namespace MathUtils
{
	/// <summary>
	/// General utility extensions to System.Int32
	/// </summary>
	public static class IntExtensions
	{
		/// <summary>
		/// Clamp an integer between two values
		/// </summary>
		/// <param name="min">Minimum value</param>
		/// <param name="max">Maximum value</param>
		/// <returns>This int's value, but no less than min, and no more than max</returns>
		public static int Clamp(this int val, int min, int max)
		{
			return Math.Max(min, Math.Min(val, max));
		}

		/// <summary>
		/// Check if an integer is within the given range inclusive
		/// </summary>
		/// <param name="min">Minimum value</param>
		/// <param name="max">Maximum value</param>
		/// <returns>True if this value is between min and max inclusive, false otherwise</returns>
		public static bool Between(this int val, int min, int max)
		{
			return val >= min && val <= max;
		}

		/// <summary>
		/// Clamp an integer between two values
		/// </summary>
		/// <param name="min">Minimum value</param>
		/// <param name="max">Maximum value</param>
		/// <returns>This long's value, but no less than min, and no more than max</returns>
		public static long Clamp(this long val, long min, long max)
		{
			return Math.Max(min, Math.Min(val, max));
		}

		/// <summary>
		/// Check if an integer is within the given range inclusive
		/// </summary>
		/// <param name="min">Minimum value</param>
		/// <param name="max">Maximum value</param>
		/// <returns>True if this value is between min and max inclusive, false otherwise</returns>
		public static bool Between(this long val, long min, long max)
		{
			return val >= min && val <= max;
		}

	}
}
