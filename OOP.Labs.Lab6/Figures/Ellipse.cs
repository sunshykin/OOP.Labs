using System;
using System.Drawing;

namespace OOP.Labs.Lab6.Figures
{
	public class Ellipse : Figure
	{
		/// <summary>
		/// Меньший радиус эллипса
		/// </summary>
		public int MinRadius;

		/// <summary>
		/// Больший радиус эллипса
		/// </summary>
		public int MaxRadius;

		public Ellipse(double w, double h) : base(w, h)
		{
			var lesser = w < h ? w : h;
			var rnd = new Random(DateTime.Now.Millisecond);
			MinRadius = rnd.Next((int)Math.Round(lesser / 4, 0), (int)Math.Round(lesser / 2, 0));
			MaxRadius = rnd.Next((int)Math.Round(lesser / 4, 0), (int)Math.Round(lesser / 2, 0));
		}

		public Ellipse(double w, double h, Point center) : this(w, h)
		{
			Center = center;
		}

		public override bool IsPointInArea(Point point)
		{
			int absWidth = Math.Abs(point.X - Center.X),
				absHeight = Math.Abs(point.Y - Center.Y);

			return (double) (absHeight * absHeight) / (MinRadius * MinRadius) +
			       (double) (absWidth * absWidth) / (MaxRadius * MaxRadius) <= 1;
		}
	}
}
