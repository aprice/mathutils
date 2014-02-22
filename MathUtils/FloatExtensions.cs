using System;

namespace MathUtils
{
	public static class FloatExtensions
	{
		public static Single Clamp(this Single val, Single min, Single max)
		{
			return Math.Max(min, Math.Min(val, max));
		}

		public static Int32 FloorToInt(this Single val)
		{
			return (int)Math.Floor(val);
		}

		public static Int32 RoundToInt(this Single val)
		{
			return (int)Math.Round(val);
		}

		public static Int32 CeilToInt(this Single val)
		{
			return (int)Math.Ceiling(val);
		}

		public static Int32 FloorToInt(this Double val)
		{
			return (int)Math.Floor(val);
		}

		public static Int32 RoundToInt(this Double val)
		{
			return (int)Math.Round(val);
		}

		public static Int32 CeilToInt(this Double val)
		{
			return (int)Math.Ceiling(val);
		}

		public static Boolean Between(this Single val, Single min, Single max)
		{
			return val >= min && val <= max;
		}
	}
}
