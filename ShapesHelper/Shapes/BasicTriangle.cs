using ShapesHelper.Interfaces;

namespace ShapesHelper.Shapes
{
	// Обычный треугольник
	public class BasicTriangle : IShape
	{
		private double _sideA;
		private double _sideB;
		private double _sideC;

		public BasicTriangle(double a, double b, double c)
		{
			if (a + b <= c || a + c <= b || b + c <= a)
			{
				throw new ArgumentException("Такого треугольника не может существовать");
			}

			SideA = a;
			SideB = b;
			SideC = c;
		}

		public double SideA { get => _sideA; set => _sideA = value; }
		public double SideB { get => _sideB; set => _sideB = value; }
		public double SideC { get => _sideC; set => _sideC = value; }

		public double GetArea()
		{
			// Полупериметр
			var sp = (_sideA + _sideB + _sideC) / 2;
			return Math.Sqrt(sp * (sp - _sideA) * (sp - _sideB) * (sp - _sideC));
		}
		
		// Проверка является ли треугольник прямоугольным
		public bool IsRightTriangle()
		{
			return (_sideA * _sideA + _sideB * _sideB == _sideC * _sideC) ||
				   (_sideA * _sideA + _sideC * _sideC == _sideB * _sideB) ||
				   (_sideC * _sideC + _sideB * _sideB == _sideA * _sideA);
		}
	}
}
