using System;

namespace MathUtils
{
	/// <summary>
	/// Rectangular area in integer coordinates
	/// </summary>
	[Serializable]
	public struct Bounds
	{
		/// <summary>
		/// 
		/// </summary>
		public Vector Position;
		public Vector Size;

		public Bounds(Vector position, Vector size)
			: this()
		{
			Position = position;
			Size = size;
		}

		public Bounds(Vector position, int width, int height)
			: this()
		{
			Position = position;
			Size = new Vector(width, height);
		}

		public Bounds(int x, int y, int width, int height)
			: this()
		{
			Position = new Vector(x, y);
			Size = new Vector(width, height);
		}

		public int Left
		{
			get
			{
				return Position.X;
			}
			set
			{
				Position = new Vector(value, Position.Y);
			}
		}
		public int Top
		{
			get
			{
				return Position.Y;
			}
			set
			{
				Position = new Vector(Position.X, value);
			}
		}
		public int Right
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
		public int Bottom
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

		public int Width
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

		public int Height
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

		public Vector Center
		{
			get
			{
				return new Vector((Left + Right) / 2, (Top + Bottom) / 2);
			}
		}

		public bool Contains(Vector pos)
		{
			return pos.X.Between(Left, Right) && pos.Y.Between(Top, Bottom);
		}

		public bool Contains(Bounds that)
		{
			return (Contains(that.Position) && Contains(new Vector(that.Right, that.Bottom)));
		}

		public bool Overlaps(Bounds that)
		{
			return that.Bottom > this.Top && that.Top < this.Bottom
				&& that.Left < this.Right && that.Right > this.Left;
		}

		public override string ToString()
		{
			return "[" + Position.ToString() + "," + Size.ToString() + "]";
		}

		public override bool Equals(object that)
		{
			if (that is Bounds)
			{
				return that.ToString().Equals(ToString());
			}
			return false;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public static bool operator ==(Bounds lhs, Bounds rhs)
		{
			return lhs.Equals(rhs);
		}

		public static bool operator !=(Bounds lhs, Bounds rhs)
		{
			return !lhs.Equals(rhs);
		}
	}
}
