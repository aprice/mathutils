using System;

namespace MathUtils
{
	/**
	 * <summary>
	 * Rectangular area in float coordinates
	 * </summary>
	 */
	[Serializable()]
	public struct FloatBounds
	{
		public FloatVector Position;
		public FloatVector Size;

		public FloatBounds(FloatVector position, FloatVector size)
			: this()
		{
			Position = position;
			Size = size;
		}

		public FloatBounds(FloatVector position, float width, float height)
			: this()
		{
			Position = position;
			Size = new FloatVector(width, height);
		}

		public FloatBounds(float x, float y, float width, float height)
			: this()
		{
			Position = new FloatVector(x, y);
			Size = new FloatVector(width, height);
		}

		public float Left
		{
			get
			{
				return Position.X;
			}
			set
			{
				Position = new FloatVector(value, Position.Y);
			}
		}
		public float Top
		{
			get
			{
				return Position.Y;
			}
			set
			{
				Position = new FloatVector(Position.X, value);
			}
		}
		public float Right
		{
			get
			{
				return Left + Width;
			}
			set
			{
				Left = value - Width;
			}
		}
		public float Bottom
		{
			get
			{
				return Top + Height;
			}
			set
			{
				Top = value - Height;
			}
		}

		public float Width
		{
			get
			{
				return Size.X;
			}

			set
			{
				Size.X = value;
			}
		}

		public float Height
		{
			get
			{
				return Size.Y;
			}
			set
			{
				Size.Y = value;
			}
		}

		public FloatVector Center
		{
			get
			{
				return new FloatVector((Left + Right) / 2, (Top + Bottom) / 2);
			}
		}

		public bool Contains(FloatVector pos)
		{
			return pos.X.Between(Left, Right) && pos.Y.Between(Top, Bottom);
		}

		public override string ToString()
		{
			return "[" + Position.ToString() + "," + Size.ToString() + "]";
		}

		public override bool Equals(object that)
		{
			if (that is FloatBounds)
			{
				return that.ToString().Equals(ToString());
			}
			return false;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public static bool operator ==(FloatBounds lhs, FloatBounds rhs)
		{
			return lhs.Equals(rhs);
		}

		public static bool operator !=(FloatBounds lhs, FloatBounds rhs)
		{
			return !lhs.Equals(rhs);
		}
	}
}
