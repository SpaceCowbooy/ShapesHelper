using ShapesHelper.Interfaces;

namespace ShapesHelper.Shapes
{
	// Обычный круг
	public class BasicCircle : IShape
	{
		private double _radius;

		public BasicCircle(double radius)
		{
			Radius = radius;
		}

		public double Radius { get => _radius; set => _radius = value; }

		public double GetArea()
		{
			return Math.PI * _radius * _radius;
		}
	}
}