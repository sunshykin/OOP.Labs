using System;
using OOP.Labs.Lab7.Figures;

namespace OOP.Labs.Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down 2 sides and angle for figures splitting them with spaces:");
	        var line = Console.ReadLine();
	        var vals = line.Split(' ');

	        if (vals.Length != 3)
	        {
				Console.WriteLine("Wrong count of arguments.");
		        Console.ReadKey();
		        return;
	        }

	        double side1 = double.Parse(vals[0]),
		        side2 = double.Parse(vals[1]),
		        angle = double.Parse(vals[2]);
	        double minSide = side1 < side2 ? side1 : side2,
		        maxSide = side1 > side2 ? side1 : side2;
	        Figure fig;

			Console.WriteLine("Creating Parallelogram:");
			fig = new Parallelogram(minSide, maxSide, angle);
			Console.WriteLine($"Area = {fig.Area():F3}\tPerimeter = {fig.Perimeter():F3}\n");

	        Console.WriteLine("Creating Rectangle:");
	        fig = new Rectangle(minSide, maxSide);
	        Console.WriteLine($"Area = {fig.Area():F3}\tPerimeter = {fig.Perimeter():F3}\n");

	        Console.WriteLine("Creating Square:");
	        fig = new Square(maxSide);
	        Console.WriteLine($"Area = {fig.Area():F3}\tPerimeter = {fig.Perimeter():F3}\n");

			Console.WriteLine("Creating Rhomb:");
	        fig = new Rhomb(maxSide, angle);
	        Console.WriteLine($"Area = {fig.Area():F3}\tPerimeter = {fig.Perimeter():F3}\n");

	        Console.ReadKey();
        }
    }
}
