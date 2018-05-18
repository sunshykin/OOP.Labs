using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Labs.Lab7.Interfaces
{
    interface IFigure
    {
		/// <summary>
		/// Стороны фигуры
		/// </summary>
		double[] Sides { get; set; }

	    /// <summary>
	    /// Периметр фигуры
	    /// </summary>
	    double Perimeter();

	}
}
