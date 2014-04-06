using System;

namespace MathUtils
{
	/// <summary>
	/// An integer value clamped between a set of Min and Max values.
	/// </summary>
	/// <remarks>
	/// All math operators overloaded to keep Value between Min and Max, inclusive.
	/// </remarks>
	[Serializable]
	public struct ClampedInt : IComparable<ClampedInt>
	{
		public int Min { get; private set; }
		public int Value { get; private set; }
		public int Max { get; private set; }

		public ClampedInt(int max)
			: this()
		{
			Min = Value = 0;
			Max = max;
		}

		public ClampedInt(int value, int max)
			: this()
		{
			Min = 0;
			Value = value.Clamp(0, max);
			Max = max;
		}

		public ClampedInt(int min, int value, int max)
			: this()
		{
			Min = min;
			Value = value.Clamp(min, max);
			Max = max;
		}

		public override string ToString()
		{
			return "[" + this.Min + "/" + this.Value + "/" + this.Max + "]";
		}

		public override bool Equals(object obj)
		{
			if (obj is ClampedInt)
			{
				return ((ClampedInt)obj).ToString().Equals(this.ToString());
			}

			return false;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public int CompareTo(ClampedInt that)
		{
			return this.Value - that.Value;
		}

		public bool InRange(int value)
		{
			return value.Between(Min, Max);
		}

		public static implicit operator int(ClampedInt obj)
		{
			return obj.Value;
		}

		public static explicit operator float(ClampedInt obj)
		{
			return (float)obj.Value;
		}

		public static ClampedInt operator +(ClampedInt lhs, ClampedInt rhs)
		{
			return new ClampedInt()
			{
				Min = lhs.Min,
				Value = (lhs.Value + rhs.Value).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static ClampedInt operator -(ClampedInt lhs, ClampedInt rhs)
		{
			return new ClampedInt()
			{
				Min = lhs.Min,
				Value = (lhs.Value - rhs.Value).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static bool operator ==(ClampedInt lhs, ClampedInt rhs)
		{
			return lhs.Value == rhs.Value;
		}

		public static bool operator !=(ClampedInt lhs, ClampedInt rhs)
		{
			return lhs.Value != rhs.Value;
		}

		public static bool operator <(ClampedInt lhs, ClampedInt rhs)
		{
			return lhs.Value < rhs.Value;
		}

		public static bool operator <=(ClampedInt lhs, ClampedInt rhs)
		{
			return lhs.Value <= rhs.Value;
		}

		public static bool operator >(ClampedInt lhs, ClampedInt rhs)
		{
			return lhs.Value > rhs.Value;
		}

		public static bool operator >=(ClampedInt lhs, ClampedInt rhs)
		{
			return lhs.Value >= rhs.Value;
		}

		public static ClampedInt operator +(ClampedInt lhs, int rhs)
		{
			return new ClampedInt()
			{
				Min = lhs.Min,
				Value = (lhs.Value + rhs).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static ClampedInt operator -(ClampedInt lhs, int rhs)
		{
			return new ClampedInt()
			{
				Min = lhs.Min,
				Value = (lhs.Value - rhs).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static ClampedInt operator *(ClampedInt lhs, int rhs)
		{
			return new ClampedInt()
			{
				Min = lhs.Min,
				Value = (lhs.Value * rhs).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static ClampedInt operator /(ClampedInt lhs, int rhs)
		{
			return new ClampedInt()
			{
				Min = lhs.Min,
				Value = (lhs.Value / rhs).Clamp(lhs.Min, lhs.Max),
				Max = lhs.Max
			};
		}

		public static bool operator ==(ClampedInt lhs, int rhs)
		{
			return lhs.Value == rhs;
		}

		public static bool operator !=(ClampedInt lhs, int rhs)
		{
			return lhs.Value != rhs;
		}

		public static bool operator <(ClampedInt lhs, int rhs)
		{
			return lhs.Value < rhs;
		}

		public static bool operator <=(ClampedInt lhs, int rhs)
		{
			return lhs.Value <= rhs;
		}

		public static bool operator >(ClampedInt lhs, int rhs)
		{
			return lhs.Value > rhs;
		}

		public static bool operator >=(ClampedInt lhs, int rhs)
		{
			return lhs.Value >= rhs;
		}

		public static int operator +(int lhs, ClampedInt rhs)
		{
			return lhs + rhs.Value;
		}

		public static int operator -(int lhs, ClampedInt rhs)
		{
			return lhs - rhs.Value;
		}

		public static int operator *(int lhs, ClampedInt rhs)
		{
			return lhs * rhs.Value;
		}

		public static int operator /(int lhs, ClampedInt rhs)
		{
			return lhs / rhs.Value;
		}


		public static bool operator ==(int lhs, ClampedInt rhs)
		{
			return lhs == rhs.Value;
		}

		public static bool operator !=(int lhs, ClampedInt rhs)
		{
			return lhs != rhs.Value;
		}

		public static bool operator <(int lhs, ClampedInt rhs)
		{
			return lhs < rhs.Value;
		}

		public static bool operator <=(int lhs, ClampedInt rhs)
		{
			return lhs <= rhs.Value;
		}

		public static bool operator >(int lhs, ClampedInt rhs)
		{
			return lhs > rhs.Value;
		}

		public static bool operator >=(int lhs, ClampedInt rhs)
		{
			return lhs >= rhs.Value;
		}
	}
}
