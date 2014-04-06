using System;
using MathUtils;

namespace MathUtils
{
	/// <summary>
	/// Single point in integer coordinates
	/// </summary>
	[Serializable]
	public struct Vector : IComparable<Vector>
	{
		public int X;
		public int Y;

		public Vector(int newX, int newY)
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
			if (obj is Vector)
			{
				Vector that = (Vector)obj;
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

		public static bool operator ==(Vector lhs, Vector rhs)
		{
			return lhs.Equals(rhs);
		}

		public static bool operator !=(Vector lhs, Vector rhs)
		{
			return !lhs.Equals(rhs);
		}

		public static Vector operator +(Vector lhs, Vector rhs)
		{
			return new Vector(lhs.X + rhs.X, lhs.Y + rhs.Y);
		}

		public static Vector operator +(Vector lhs, int rhs)
		{
			return new Vector(lhs.X + rhs, lhs.Y + rhs);
		}

		public static Vector operator -(Vector lhs, Vector rhs)
		{
			return new Vector(lhs.X - rhs.X, lhs.Y - rhs.Y);
		}

		public static Vector operator -(Vector lhs, int rhs)
		{
			return new Vector(lhs.X - rhs, lhs.Y - rhs);
		}

		public static Vector operator *(Vector lhs, int rhs)
		{
			return new Vector(lhs.X * rhs, lhs.Y * rhs);
		}

		public static Vector operator /(Vector lhs, int rhs)
		{
			return new Vector(lhs.X / rhs, lhs.Y / rhs);
		}

		public int CompareTo(Vector that)
		{
			return this.Magnitude.CeilToInt() - that.Magnitude.CeilToInt();
		}
	}
}
