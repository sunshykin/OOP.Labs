using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Labs.Common.Models
{
	public class Vertex
	{
		/// <summary>
		/// Отображаемый номер вершины
		/// </summary>
		public int Number;

		/// <summary>
		/// Расположение вершины
		/// </summary>
		public Rectangle Rectangle;

		/// <summary>
		/// Центр вершины
		/// </summary>
		public Point Center
		{
			get
			{
				int half = Rectangle.Width / 2;
				return new Point(Rectangle.X + half, Rectangle.Y + half);
			}
		}

		public Vertex(int num, Rectangle rect)
		{
			Number = num;
			Rectangle = rect;
		}

	}
}
