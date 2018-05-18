namespace OOP.Labs.Common.Models
{
	/// <summary>
	/// Класс "Полином второй степени"
	/// </summary>
	/// <remarks>
	/// Полином имеет вид A*x^2 + B*x + C
	/// </remarks>
	/// <typeparam name="T">Тип коэффициентов</typeparam>
	public class SecondDegreePolynom<T> where T: INumerable
	{
		/// <summary>
		/// Коэффициент при x^2
		/// </summary>
		public T A { get; set; }

		/// <summary>
		/// Коэффициент при x
		/// </summary>
		public T B { get; set; }

		/// <summary>
		/// Свободный член
		/// </summary>
		public T C { get; set; }

		public SecondDegreePolynom(T a, T b, T c)
		{
			A = a;
			B = b;
			C = c;
		}

		public T[] GetRoots()
		{
			var dis = B.Multiply(B).Subtract(A.Multiply(C).MultiplyByNumber(4));
			var x1 = (T) B.MultiplyByNumber(-1).Add(dis.Sqrt()).Divide(A.MultiplyByNumber(2));
			var x2 = (T) B.MultiplyByNumber(-1).Subtract(dis.Sqrt()).Divide(A.MultiplyByNumber(2));

			return new [] {x1, x2};
		}

		public T GetValue(T x)
		{
			return (T) A.Multiply(x.Multiply(x)).Add(B.Multiply(x)).Add(C);
		}
	}
}
