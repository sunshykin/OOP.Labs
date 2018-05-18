using System;
using System.Drawing;

namespace OOP.Labs.Lab6.Figures
{
	public class Rectangle : Figure
	{
		/// <summary>
		/// Горизонтальная сторона прямоугольника
		/// </summary>
		public int HorzSide;

		/// <summary>
		/// Вертикальная сторона прямоугольника
		/// </summary>
		public int VertSide;

		public Rectangle(double w, double h) : base(w, h)
		{
			var lesser = w < h ? w : h;
			var rnd = new Random(DateTime.Now.Millisecond);
			HorzSide = rnd.Next((int)Math.Round(lesser / 4, 0), (int)Math.Round(lesser / 2, 0));
			VertSide = rnd.Next((int)Math.Round(lesser / 4, 0), (int)Math.Round(lesser / 2, 0));
		}

		public Rectangle(double w, double h, Point center) : this(w, h)
		{
			Center = center;
		}

		public override bool IsPointInArea(Point point)
		{
			int absWidth = Math.Abs(point.X - Center.X),
				absHeight = Math.Abs(point.Y - Center.Y);

			return absWidth <= HorzSide / 2 && absHeight <= VertSide / 2;
		}
	}
}
