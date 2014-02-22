using System;

namespace MathUtils
{
	/**
	 * <summary>
	 * Single pofloat in floating-pofloat coordinates
	 * </summary>
	 */
	[Serializable()]
	public struct FloatVector
	{
		public float X;
		public float Y;

		public FloatVector(float newX, float newY)
		{
			X = newX;
			Y = newY;
		}

		public override string ToString()
		{
			return "[" + X + "," + Y + "]";
		}

		public override bool Equals(object obj)
		{
			if (obj is FloatVector)
			{
				FloatVector that = (FloatVector)obj;
				return this.X == that.X && this.Y == that.Y;
			}
			else
			{
				return false;
			}
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public float Magnitude
		{
			get
			{
				return MathFunctions.Hypotenuse(X, Y);
			}
		}

		public static bool operator ==(FloatVector lhs, FloatVector rhs)
		{
			return lhs.Equals(rhs);
		}

		public static bool operator !=(FloatVector lhs, FloatVector rhs)
		{
			return !lhs.Equals(rhs);
		}

		public static FloatVector operator +(FloatVector lhs, FloatVector rhs)
		{
			return new FloatVector(lhs.X + rhs.X, lhs.Y + rhs.Y);
		}

		public static FloatVector operator +(FloatVector lhs, float rhs)
		{
			return new FloatVector(lhs.X + rhs, lhs.Y + rhs);
		}

		public static FloatVector operator -(FloatVector lhs, FloatVector rhs)
		{
			return new FloatVector(lhs.X - rhs.X, lhs.Y - rhs.Y);
		}

		public static FloatVector operator -(FloatVector lhs, float rhs)
		{
			return new FloatVector(lhs.X - rhs, lhs.Y - rhs);
		}

		public static FloatVector operator *(FloatVector lhs, float rhs)
		{
			return new FloatVector(lhs.X * rhs, lhs.Y * rhs);
		}

		public static FloatVector operator /(FloatVector lhs, float rhs)
		{
			return new FloatVector(lhs.X / rhs, lhs.Y / rhs);
		}
	}
}
