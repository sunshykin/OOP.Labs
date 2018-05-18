using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Labs.Lab7.Interfaces
{
    interface ISquare : IParallelogram
	{
		double EachSide { get; set; }
    }
}
