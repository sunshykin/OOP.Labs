using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Labs.Common.Models
{
	public class DiagonalMatrix : Matrix<ComplexNumber>, INumerable
	{
		/// <summary>
		/// Размерность матрицы
		/// </summary>
		private int Dimension;

		public DiagonalMatrix(int n) : base(n, n)
		{
			Dimension = n;
			for (int i = 0; i < Dimension; i++)
			{
				for (int j = 0; j < Dimension; j++)
				{
					Value[i, j] = new ComplexNumber(0);
				}
			}
		}

		public DiagonalMatrix(ComplexNumber[,] matr) : base(matr)
		{
			Dimension = Value.GetLength(0);
		}

		#region INumerable

		public INumerable Multiply(INumerable num)
		{
			if (num is DiagonalMatrix matr)
			{
				var newMatrix = new ComplexNumber[Dimension, Dimension];
				for (int i = 0; i < Dimension; i++)
					newMatrix[i, i] = Value[i, i].Multiply(matr.Value[i, i]) as ComplexNumber;

				return new DiagonalMatrix(newMatrix);
			}
			else
				return new DiagonalMatrix(1);
		}

		public INumerable MultiplyByNumber(double num)
		{
			var newMatrix = new ComplexNumber[Dimension, Dimension];
			for (int i = 0; i < Dimension; i++)
				newMatrix[i, i] = Value[i, i].MultiplyByNumber(num) as ComplexNumber;

			return new DiagonalMatrix(newMatrix);
		}

		public INumerable Divide(INumerable num)
		{
			if (num is DiagonalMatrix matr)
			{
				var newMatrix = new ComplexNumber[Dimension, Dimension];
				for (int i = 0; i < Dimension; i++)
					newMatrix[i, i] = Value[i, i].Divide(matr.Value[i, i]) as ComplexNumber;

				return new DiagonalMatrix(newMatrix);
			}
			else
				return new DiagonalMatrix(1);
		}

		public INumerable Add(INumerable num)
		{
			if (num is DiagonalMatrix matr)
			{
				var newMatrix = new ComplexNumber[Dimension, Dimension];
				for (int i = 0; i < Dimension; i++)
					newMatrix[i, i] = Value[i, i].Add(matr.Value[i, i]) as ComplexNumber;

				return new DiagonalMatrix(newMatrix);
			}
			else
				return new DiagonalMatrix(1);
		}

		public INumerable Subtract(INumerable num)
		{
			if (num is DiagonalMatrix matr)
			{
				var newMatrix = new ComplexNumber[Dimension, Dimension];
				for (int i = 0; i < Dimension; i++)
					newMatrix[i, i] = Value[i, i].Subtract(matr.Value[i, i]) as ComplexNumber;

				return new DiagonalMatrix(newMatrix);
			}
			else
				return new DiagonalMatrix(1);
		}

		public INumerable Sqrt()
		{
			var newMatrix = new ComplexNumber[Dimension, Dimension];
			for (int i = 0; i < Dimension; i++)
				newMatrix[i, i] = Value[i, i].Sqrt() as ComplexNumber;

			return new DiagonalMatrix(newMatrix);
		}

		#endregion
	}
}
