using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathUtils.Test
{
	[TestClass]
	public class CartesianBoundsTest
	{
		[TestMethod]
		public void ExtentsTest()
		{
			CartesianBounds subject = new CartesianBounds(3, 3, 10, 10);
			Assert.AreEqual(3, subject.Left);
			Assert.AreEqual(3, subject.Bottom);
			Assert.AreEqual(13, subject.Right);
			Assert.AreEqual(13, subject.Top);
		}

		[TestMethod]
		public void ContainsVectorTest()
		{
			CartesianBounds subject;
			Vector obj;
			subject = new CartesianBounds(3, 3, 10, 10);
			obj = new Vector(5, 5);
			Assert.IsTrue(subject.Contains(obj));

			obj = new Vector(50, 50);
			Assert.IsFalse(subject.Contains(obj));
		}

		[TestMethod]
		public void ContainsBoundsTest()
		{
			CartesianBounds subject, obj;
			subject = new CartesianBounds(3, 3, 10, 10);
			obj = new CartesianBounds(5, 5, 3, 3);
			Assert.IsTrue(subject.Contains(obj));

			obj = new CartesianBounds(1, 1, 50, 50);
			Assert.IsFalse(subject.Contains(obj));

			obj = new CartesianBounds(1, 1, 5, 5);
			Assert.IsFalse(subject.Contains(obj));

			obj = new CartesianBounds(100, 100, 10, 10);
			Assert.IsFalse(subject.Contains(obj));
		}

		[TestMethod]
		public void OverlapsTest()
		{
			CartesianBounds subject, obj;
			subject = new CartesianBounds(3, 3, 10, 10);
			obj = new CartesianBounds(5, 5, 3, 3);
			Assert.IsTrue(subject.Overlaps(obj));

			obj = new CartesianBounds(1, 1, 50, 50);
			Assert.IsTrue(subject.Overlaps(obj));

			obj = new CartesianBounds(1, 1, 5, 5);
			Assert.IsTrue(subject.Overlaps(obj));

			obj = new CartesianBounds(8, 8, 5, 5);
			Assert.IsTrue(subject.Overlaps(obj));

			obj = new CartesianBounds(100, 100, 10, 10);
			Assert.IsFalse(subject.Overlaps(obj));
		}
	}
}
