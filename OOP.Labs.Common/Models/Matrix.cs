namespace OOP.Labs.Common.Models
{
	public class Matrix<T>
	{
		public T[,] Value;

		public Matrix()
		{

		}

		public Matrix(int n, int m)
		{
			Value = new T[n, m];
		}

		public Matrix(T[,] matrix)
		{
			Value = matrix;
		}
	}
}
