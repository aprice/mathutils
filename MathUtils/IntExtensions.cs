using System;

namespace MathUtils
{
	/**
	 * <summary>
	 * Int32 utility extensions
	 * </summary>
	 */
	public static class IntExtensions
	{
		public static Int32 Clamp(this Int32 val, Int32 min, Int32 max)
		{
			return Math.Max(min, Math.Min(val, max));
		}

		public static Boolean Between(this Int32 val, Int32 min, Int32 max)
		{
			return val >= min && val <= max;
		}
	}
}
