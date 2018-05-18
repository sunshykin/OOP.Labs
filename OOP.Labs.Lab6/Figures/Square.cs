using System;
using System.Drawing;

namespace OOP.Labs.Lab6.Figures
{
	public class Square : Figure
	{
		/// <summary>
		/// Сторона квадрата
		/// </summary>
		public int Side;

		public Square(double w, double h) : base(w, h)
		{
			var lesser = w < h ? w : h;
			var rnd = new Random(DateTime.Now.Millisecond);
			Side = rnd.Next((int)Math.Round(lesser / 4, 0), (int)Math.Round(lesser / 2, 0));
		}

		public Square(double w, double h, Point center) : this(w, h)
		{
			Center = center;
		}

		public override bool IsPointInArea(Point point)
		{
			int absWidth = Math.Abs(point.X - Center.X),
				absHeight = Math.Abs(point.Y - Center.Y);

			return absWidth <= Side / 2 && absHeight <= Side / 2;
		}
	}
}
