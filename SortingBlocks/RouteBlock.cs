namespace SortLib
{
	/// <summary>
	/// Блок данных. Содержит точку отправления и точку назначения
	/// </summary>
	/// <typeparam name="T">Элементы массива должны быть одного типа</typeparam>
	public class RouteBlock<T>
	{
		public T Input { get; set; }
		public T Output { get; set; }

		/// <summary>
		/// Конструктор блока данных по-умолчанию
		/// </summary>
		public RouteBlock() { }

		/// <summary>
		/// Конструктор блока данных с заранее определёнными точками отправления и назначения
		/// </summary>
		/// <param name="input">Точка отправления</param>
		/// <param name="output">Точка назначения</param>
		public RouteBlock( T input, T output )
		{
			Input = input;
			Output = output;
		}
	}
}
