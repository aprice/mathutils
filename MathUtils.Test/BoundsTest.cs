using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathUtils.Test
{
	[TestClass]
	public class BoundsTest
	{
		[TestMethod]
		public void ExtentsTest()
		{
			Bounds subject = new Bounds(3, 3, 10, 10);
			Assert.AreEqual(3, subject.Left);
			Assert.AreEqual(3, subject.Top);
			Assert.AreEqual(13, subject.Right);
			Assert.AreEqual(13, subject.Bottom);
		}

		[TestMethod]
		public void ContainsVectorTest()
		{
			Bounds subject;
			Vector obj;
			subject = new Bounds(3, 3, 10, 10);
			obj = new Vector(5, 5);
			Assert.IsTrue(subject.Contains(obj));

			obj = new Vector(50, 50);
			Assert.IsFalse(subject.Contains(obj));
		}

		[TestMethod]
		public void ContainsBoundsTest()
		{
			Bounds subject, obj;
			subject = new Bounds(3, 3, 10, 10);
			obj = new Bounds(5, 5, 3, 3);
			Assert.IsTrue(subject.Contains(obj));

			obj = new Bounds(1, 1, 50, 50);
			Assert.IsFalse(subject.Contains(obj));

			obj = new Bounds(1, 1, 5, 5);
			Assert.IsFalse(subject.Contains(obj));

			obj = new Bounds(100, 100, 10, 10);
			Assert.IsFalse(subject.Contains(obj));
		}

		[TestMethod]
		public void OverlapsTest()
		{
			Bounds subject, obj;
			subject = new Bounds(3, 3, 10, 10);
			obj = new Bounds(5, 5, 3, 3);
			Assert.IsTrue(subject.Overlaps(obj));

			obj = new Bounds(1, 1, 50, 50);
			Assert.IsTrue(subject.Overlaps(obj));

			obj = new Bounds(1, 1, 5, 5);
			Assert.IsTrue(subject.Overlaps(obj));

			obj = new Bounds(8, 8, 5, 5);
			Assert.IsTrue(subject.Overlaps(obj));

			obj = new Bounds(100, 100, 10, 10);
			Assert.IsFalse(subject.Overlaps(obj));
		}
	}
}
