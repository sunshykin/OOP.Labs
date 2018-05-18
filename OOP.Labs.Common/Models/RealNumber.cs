using System;

namespace OOP.Labs.Common.Models
{
	public class RealNumber : INumerable
	{
		public double Value;

		public RealNumber(object num)
		{
			var strNum = num.ToString().Replace('.', ',');

			double.TryParse(strNum, out Value);
		}

		#region INumerable

		public INumerable Multiply(INumerable num)
		{
			if (num is RealNumber)
				return new RealNumber(Value * ((RealNumber) num).Value);
			else
				return new RealNumber(0);
		}

		public INumerable MultiplyByNumber(double num)
		{
			return new RealNumber(Value * num);
		}
		
		public INumerable Divide(INumerable num)
		{
			if (num is RealNumber)
				return new RealNumber(Value / ((RealNumber)num).Value);
			else
				return new RealNumber(0);
		}

		public INumerable Add(INumerable num)
		{
			if (num is RealNumber)
				return new RealNumber(Value + ((RealNumber)num).Value);
			else
				return new RealNumber(0);
		}

		public INumerable Subtract(INumerable num)
		{
			if (num is RealNumber)
				return new RealNumber(Value - ((RealNumber)num).Value);
			else
				return new RealNumber(0);
		}

		public INumerable Sqrt()
		{
			return new RealNumber(Math.Sqrt(Value));
		}

		#endregion

		/// <summary>
		/// Проверка формата
		/// </summary>
		/// <returns></returns>
		public static bool IsSuitable(string str)
		{
			return double.TryParse(str.Replace('.', ','), out double value);
		}
	}
}
