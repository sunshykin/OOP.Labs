using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOP.Labs.Common.Models
{
	public class ComplexNumber : INumerable
	{
		public Complex Value;

		private static string _regexPattern = @"^([-+]?(?:\d+|\d*\.\d+))?[-+]?(\d+|\d*\.\d+)?[ij]$";
		public static Regex RegEx = new Regex(_regexPattern);

		public ComplexNumber(string num)
		{
			var strNum = num.Replace(',', '.');

			Match match = RegEx.Match(strNum);

			if (match.Groups.Count == 3 && match.Groups[2].Value.IndexOf('.') != 0)
			{
				int index = strNum.LastIndexOf(match.Groups[2].Value);
				index = index < 1 ? 0 : index - 1;
				int multImg = strNum[index] == '-' ? -1 : 1; 
				Value = new Complex(double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture),
					double.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture) * multImg);
			}
			else
			{
				int mult = strNum.Contains("-") ? -1 : 1;
				strNum = strNum.Replace("+", "").Replace("-", "").Trim(' ');
				if (strNum.Contains('i'))
				{
					strNum = strNum.Replace("i", "");
					if (double.TryParse(strNum, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double img))
						Value = new Complex(0, img * mult);
					else
						Value = new Complex(double.NaN, 0);
				}
				else
				{
					if (double.TryParse(strNum, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double real))
						Value = new Complex(real * mult, 0);
					else
						Value = new Complex(double.NaN, double.NaN);
				}
			}
		}

		public ComplexNumber(Complex val)
		{
			Value = val;
		}

		public ComplexNumber(double real, double img)
		{
			Value = new Complex(real, img);
		}

		public override string ToString()
		{
			var sign = Value.Imaginary > 0 ? "+ " : "";
			return (double.IsNaN(Value.Real) ? "" : $"{Value.Real:F3} ") +
			       (double.IsNaN(Value.Imaginary) || Value.Imaginary == 0 ? "" : $"{sign}{Value.Imaginary:F3}i");
		}

		#region INumerable

		public INumerable Multiply(INumerable num)
		{
			if (num is ComplexNumber compl)
				return new ComplexNumber(Value * compl.Value);
			else
				return new ComplexNumber(0);
		}

		public INumerable MultiplyByNumber(double num)
		{
			return new ComplexNumber(Value * num);
		}

		public INumerable Divide(INumerable num)
		{
			if (num is ComplexNumber compl)
				return new ComplexNumber(Value / compl.Value);
			else
				return new ComplexNumber(0);
		}

		public INumerable Add(INumerable num)
		{
			if (num is ComplexNumber compl)
				return new ComplexNumber(Value + compl.Value);
			else
				return new ComplexNumber(0);
		}

		public INumerable Subtract(INumerable num)
		{
			if (num is ComplexNumber compl)
				return new ComplexNumber(Value - compl.Value);
			else
				return new ComplexNumber(0);
		}

		public INumerable Sqrt()
		{
			return new ComplexNumber(Complex.Sqrt(Value));
		}
		
		#endregion

		/// <summary>
		/// Проверка формата
		/// </summary>
		/// <returns></returns>
		public static bool IsSuitable(string str)
		{
			var compl = new ComplexNumber(str);
			return !(double.IsNaN(compl.Value.Real) && double.IsNaN(compl.Value.Imaginary));
		}
	}
}
