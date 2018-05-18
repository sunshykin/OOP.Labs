using OOP.Labs.Lab7.Interfaces;

namespace OOP.Labs.Lab7.Figures
{
    public class Rhomb : Parallelogram, ISquare
    {
	    public Rhomb(double side, double angle) : base(side, side, angle)
	    {

	    }

		public double EachSide
		{
			get { return Sides[0]; }
			set { Sides[0] = value; }
		}
	}
}
