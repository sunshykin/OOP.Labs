using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Labs.Lab7.Figures
{
    public class Rectangle: Parallelogram
    {
	    public Rectangle()
	    {
		    Angle = 90;
		}

	    public Rectangle(double min, double max) : base(min, max, 90)
	    {

	    }

	    public override double Area()
	    {
		    return MinSide * MaxSide * Math.Sin(Angle * Math.PI / 180);
	    }
	}
}
