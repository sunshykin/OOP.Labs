using System;
using System.Drawing;

namespace OOP.Labs.Lab6.Figures
{
	public class Circle: Figure
	{
		/// <summary>
		/// Радиус окружности
		/// </summary>
		public int Radius;

		public Circle(double w, double h) : base(w, h)
		{
			var lesser = w < h ? w : h;
			Radius = new Random(DateTime.Now.Millisecond).Next((int)Math.Round(lesser / 4, 0), (int)Math.Round(lesser / 2, 0));
		}

		public Circle(double w, double h, Point center) : this(w, h)
		{
			Center = center;
		}

		public override bool IsPointInArea(Point point)
		{
			int absWidth = Math.Abs(point.X - Center.X),
				absHeight = Math.Abs(point.Y - Center.Y);

			return absHeight * absHeight + absWidth * absWidth <= Radius * Radius;
		}
	}
}
