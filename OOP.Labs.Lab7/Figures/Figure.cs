using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP.Labs.Lab7.Interfaces;

namespace OOP.Labs.Lab7.Figures
{
    public abstract class Figure : IFigure
	{
		/// <summary>
		/// Стороны фигуры
		/// </summary>
		public double[] Sides { get; set; }

		public Figure()
	    {
			Sides = new double[0];
	    }

		public Figure(int n)
	    {
			Sides = new double[n];
	    }

		/// <summary>
		/// Площадь фигуры
		/// </summary>
		public virtual double Area()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Периметр фигуры
		/// </summary>
		public virtual double Perimeter()
		{
			return 2 * Sides.Sum();
		}
	}
}
