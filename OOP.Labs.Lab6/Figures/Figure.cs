using System;
using System.Drawing;

namespace OOP.Labs.Lab6.Figures
{
	public abstract class Figure
	{
		/// <summary>
		/// Ширина мишени
		/// </summary>
		protected double AreaWidth;

		/// <summary>
		/// Высота мишени
		/// </summary>
		protected double AreaHeight;

		/// <summary>
		/// Центр фигуры
		/// </summary>
		protected Point Center;

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="w">Ширина мишени</param>
		/// <param name="h">Высота мишени</param>
		public Figure(double w, double h)
		{
			AreaWidth = w;
			AreaWidth = h;
			var rnd = new Random(DateTime.Now.Millisecond);
			Center = new Point(rnd.Next((int)w), rnd.Next((int)h));
		}

		public virtual bool IsPointInArea(Point point)
		{
			throw new NotImplementedException();
		}
	}
}
