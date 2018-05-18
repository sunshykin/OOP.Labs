using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Labs.Common.Models
{
	public class CommonMatrix : Matrix<RealNumber>
	{
		/// <summary>
		/// Количество строк
		/// </summary>
		public int Rows { get; }

		/// <summary>
		/// Количество столбцов
		/// </summary>
		public int Columns { get; }

		public CommonMatrix(int n, int m) : base(n, m)
		{
			Rows = n;
			Columns = m;

			for (int i = 0; i < Rows; i++)
			{
				for (int j = 0; j < Columns; j++)
				{
					Value[i, j] = new RealNumber(0);
				}
			}
		}

		public CommonMatrix(string filePath)
		{
			if (File.Exists(filePath))
			{
				var lines = File.ReadAllLines(filePath);

				Rows = lines.Length;
				Columns = lines[0].Split(' ').Length;
				Value = new RealNumber[Rows, Columns];

				for (int i = 0; i < Rows; i++)
				{
					var numbers = lines[i].Split(' ');
					for (int j = 0; j < Columns; j++)
					{
						Value[i, j] = new RealNumber(numbers[j]);
					}
				}
			}
		}

		public static CommonMatrix GetMatrixFromFile(string filePath)
		{
			if (!File.Exists(filePath))
				return null;

			var lines = File.ReadAllLines(filePath);
			var matrix = new CommonMatrix(lines.Length, lines[0].Split(' ').Length);

			for (int i = 0; i < matrix.Rows; i++)
			{
				var numbers = lines[i].Split(' ');
				for (int j = 0; j < matrix.Columns; j++)
				{
					matrix.Value[i,j] = new RealNumber(numbers[j]);
				}
			}

			return matrix;
		}
		
	}
}
