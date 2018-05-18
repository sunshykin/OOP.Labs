using System;
using System.Collections.Generic;
using System.Text;
using OOP.Labs.Lab7.Interfaces;

namespace OOP.Labs.Lab7.Figures
{
    public class Parallelogram : Figure, IParallelogram
	{
		public double MinSide
		{
			get { return Sides[0]; }
			set { Sides[0] = value; }
		}

		public double MaxSide
		{
			get { return Sides[1]; }
			set { Sides[1] = value; }
		}

		public double Angle { get; set; }

		public Parallelogram() : base(4)
		{
		}

		public Parallelogram(double min, double max, double angle) : this()
		{
			Sides = new[] {min, max, min, max};
			Angle = angle;
		}

		public override double Area()
		{
			return MinSide * MaxSide * Math.Sin(Angle * Math.PI / 180);
		}

		public override double Perimeter()
		{
			return 2 * (MinSide + MaxSide);
		}
	}
}
