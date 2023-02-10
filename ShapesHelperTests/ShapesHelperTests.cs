using Helper = ShapesHelper.ShapesHelper;
using ShapesHelper.Shapes;

namespace ShapesHelperTests
{
	[TestClass]
	public class ShapesHelperTests
	{
		[TestMethod]
		public void TestAreaMethods()
		{
			var triangle = new BasicTriangle(3, 4, 5);
			var triangleArea = Helper.GetArea(triangle);

			var circle = new BasicCircle(2);
			var circleArea = Helper.GetArea(circle);

			Assert.AreEqual(6, triangleArea);
			Assert.AreEqual(12.566370614359172, circleArea);
		}

		[TestMethod]
		public void TestRigthTriangle()
		{
			var rightTriangle = new BasicTriangle(7, 24, 25);
			var triangle = new BasicTriangle(3, 5, 7);

			Assert.IsTrue(Helper.IsRigthTriangle(rightTriangle));
			Assert.IsFalse(Helper.IsRigthTriangle(triangle));
		}
	}
}