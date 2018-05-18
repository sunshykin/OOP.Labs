namespace OOP.Labs.Common.Models
{
	public interface INumerable
	{
		/// <summary>
		/// Умножение
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		INumerable Multiply(INumerable num);

		/// <summary>
		/// Умножение на число
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		INumerable MultiplyByNumber(double num);

		/// <summary>
		/// Деление
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		INumerable Divide(INumerable num);

		/// <summary>
		/// Сложение
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		INumerable Add(INumerable num);

		/// <summary>
		/// Вычитание
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		INumerable Subtract(INumerable num);

		/// <summary>
		/// Квадратный корень
		/// </summary>
		/// <returns></returns>
		INumerable Sqrt();
	}
}
