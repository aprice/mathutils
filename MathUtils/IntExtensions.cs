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

		/// <summary>
		/// Increment a value, wrapping back to zero if it exceeds the given maximum
		/// </summary>
		/// <param name="oldValue">Value to increment</param>
		/// <param name="maxValue">Exclusive upper bound</param>
		/// <returns>Orignal value + 1, or 0 if original value == maxValue - 1</returns>
		public static int IncrementWrap(this int oldValue, int maxValue)
		{
			return (oldValue + 1) % maxValue;
		}

		/// <summary>
		/// Decrement a value, wrapping back to zero if it exceeds the given maximum
		/// </summary>
		/// <param name="oldValue">Value to decrement</param>
		/// <param name="maxValue">Exclusive upper bound</param>
		/// <returns>Orignal value - 1, or maxValue if original value == 0</returns>
		public static int DecrementWrap(this int oldValue, int maxValue)
		{
			return (oldValue + maxValue - 1) % maxValue;
		}
	}
}
