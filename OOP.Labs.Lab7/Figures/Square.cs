using System;
using System.Collections.Generic;
using System.Text;
using OOP.Labs.Lab7.Interfaces;

namespace OOP.Labs.Lab7.Figures
{
    class Square : Rectangle, ISquare
    {
	    public Square(double side) : base(side, side)
	    {

	    }

	    public double EachSide
	    {
		    get { return Sides[0]; }
		    set { Sides[0] = value; }
	    }

	    public override double Area()
	    {
		    return EachSide * EachSide;
	    }

	    public override double Perimeter()
	    {
		    return 4 * EachSide;
	    }

	}
}
