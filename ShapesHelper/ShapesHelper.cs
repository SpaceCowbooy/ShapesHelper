using ShapesHelper.Interfaces;
using ShapesHelper.Shapes;

namespace ShapesHelper
{
	public static class ShapesHelper
	{
		public static double GetArea(IShape shape)
		{
			return shape.GetArea();
		}

		public static bool IsRigthTriangle(BasicTriangle triangle)
		{
			return triangle.IsRightTriangle();
		}
	}
}