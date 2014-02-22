using System;

namespace MathUtils
{
	/**
	 * <summary>
	 * An floating point value permanently clamped between a set of Min and Max values.
	 * </summary>
	 * <remarks>
	 * All math operators overloaded to keep Value between Min and Max, inclusive. Useful for
	 * things like Health, Mana, and any other floateger value that must stay within a specified
	 * range.
	 * </remarks>
	 */
	[Serializable()]
	public struct ClampedFloat
	{
		public float Min { get; private set; }
		public float Value { get; private set; }
		public float Max { get; private set; }

		public ClampedFloat(float max)
			: this()
		{
			Min = Value = 0;
			Max = max;
		}

		public ClampedFloat(float value, float max)
			: this()
		{
			Min = 0;
			Value = value.Clamp(0, max);
			Max = max;
		}

		public ClampedFloat(float min, float value, float max)
			: this()
		{
			Min = min;
			Value = value.Clamp(min, max);
			Max = max;
		}

		public bool InRange(float value)
		{
			return value.Between(Min, Max);
		}

		public static implicit operator float(ClampedFloat obj)
		{
			return obj.Value;
		}

		public static ClampedFloat operator +(ClampedFloat lhs, ClampedFloat rhs)
		{
			return new ClampedFloat()
			{
				Min = lhs.Min,
				Value = (lhs.Value + rhs.Value).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static ClampedFloat operator -(ClampedFloat lhs, ClampedFloat rhs)
		{
			return new ClampedFloat()
			{
				Min = lhs.Min,
				Value = (lhs.Value - rhs.Value).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static bool operator ==(ClampedFloat lhs, ClampedFloat rhs)
		{
			return lhs.Value == rhs.Value;
		}

		public static bool operator !=(ClampedFloat lhs, ClampedFloat rhs)
		{
			return lhs.Value != rhs.Value;
		}

		public static bool operator <(ClampedFloat lhs, ClampedFloat rhs)
		{
			return lhs.Value < rhs.Value;
		}

		public static bool operator <=(ClampedFloat lhs, ClampedFloat rhs)
		{
			return lhs.Value <= rhs.Value;
		}

		public static bool operator >(ClampedFloat lhs, ClampedFloat rhs)
		{
			return lhs.Value > rhs.Value;
		}

		public static bool operator >=(ClampedFloat lhs, ClampedFloat rhs)
		{
			return lhs.Value >= rhs.Value;
		}

		public static ClampedFloat operator +(ClampedFloat lhs, float rhs)
		{
			return new ClampedFloat()
			{
				Min = lhs.Min,
				Value = (lhs.Value + rhs).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static ClampedFloat operator -(ClampedFloat lhs, float rhs)
		{
			return new ClampedFloat()
			{
				Min = lhs.Min,
				Value = (lhs.Value - rhs).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static ClampedFloat operator *(ClampedFloat lhs, float rhs)
		{
			return new ClampedFloat()
			{
				Min = lhs.Min,
				Value = (lhs.Value * rhs).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static ClampedFloat operator /(ClampedFloat lhs, float rhs)
		{
			return new ClampedFloat()
			{
				Min = lhs.Min,
				Value = (lhs.Value / rhs).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static bool operator ==(ClampedFloat lhs, float rhs)
		{
			return lhs.Value == rhs;
		}

		public static bool operator !=(ClampedFloat lhs, float rhs)
		{
			return lhs.Value != rhs;
		}

		public static bool operator <(ClampedFloat lhs, float rhs)
		{
			return lhs.Value < rhs;
		}

		public static bool operator <=(ClampedFloat lhs, float rhs)
		{
			return lhs.Value <= rhs;
		}

		public static bool operator >(ClampedFloat lhs, float rhs)
		{
			return lhs.Value > rhs;
		}

		public static bool operator >=(ClampedFloat lhs, float rhs)
		{
			return lhs.Value >= rhs;
		}

		public static float operator +(float lhs, ClampedFloat rhs)
		{
			return lhs + rhs.Value;
		}

		public static float operator -(float lhs, ClampedFloat rhs)
		{
			return lhs - rhs.Value;
		}

		public static float operator *(float lhs, ClampedFloat rhs)
		{
			return lhs * rhs.Value;
		}

		public static float operator /(float lhs, ClampedFloat rhs)
		{
			return lhs / rhs.Value;
		}


		public static bool operator ==(float lhs, ClampedFloat rhs)
		{
			return lhs == rhs.Value;
		}

		public static bool operator !=(float lhs, ClampedFloat rhs)
		{
			return lhs != rhs.Value;
		}

		public static bool operator <(float lhs, ClampedFloat rhs)
		{
			return lhs < rhs.Value;
		}

		public static bool operator <=(float lhs, ClampedFloat rhs)
		{
			return lhs <= rhs.Value;
		}

		public static bool operator >(float lhs, ClampedFloat rhs)
		{
			return lhs > rhs.Value;
		}

		public static bool operator >=(float lhs, ClampedFloat rhs)
		{
			return lhs >= rhs.Value;
		}

		public override string ToString()
		{
			return "[" + this.Min + "/" + this.Value + "/" + this.Max + "]";
		}

		public override bool Equals(object obj)
		{
			if (obj is ClampedFloat)
			{
				return ((ClampedFloat)obj).ToString().Equals(this.ToString());
			}

			return false;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}
	}
}
